using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// הוספת מוצר להזמנה
        /// </summary>
        /// <param name="order">הזמנה שרוצים להוסיף אליה מוצר</param>
        /// <param name="idProduct">קוד מוצר שרוצים להוסיף</param>
        /// <param name="quantity">כמות מהמוצר שרוצים להוסיף</param>
        /// <returns>מחזירים את רשימת המבצעים שמומשו למוצר זה</returns>
        /// <exception cref="BLNoQuantityInStock">שגיאה אם מספיק כמות במלאי</exception>
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int idProduct, int quantity)
        {
            DO.Product product = _dal.Product.Read(idProduct);
            BO.ProductInOrder p = null;
            if (order.ProductList != null)
                p = order.ProductList.FirstOrDefault(p => p.IdProduct == product.Id);
            else
            {
                order.ProductList = new List<BO.ProductInOrder> { };
            }
            if (p == null)
            {
                if (quantity <= product.QuantityInStock)
                {
                    p = new BO.ProductInOrder();
                    p.IdProduct = product.Id;
                    p.ProductName = product.ProductName;
                    p.BasePriceProduct = product.Price;
                    p.OrderQuantity = quantity;
                    order.ProductList.Add(p);

                }
                else
                {
                    throw new BO.BLNoQuantityInStock("no quantity in stock");
                }
            }
            else
            {
                if (quantity + p.OrderQuantity <= product.QuantityInStock)
                {
                    order.ProductList.Remove(p);
                    p.OrderQuantity += quantity;
                    order.ProductList.Add(p);
                }
                else
                {
                    throw new BO.BLNoQuantityInStock("no quantity in stock");
                }
            }
            SearchSaleForProduct(p, order.PreferredCustomer);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
            return p.ListSales;
        }

        /// <summary>
        /// חישוב הסכום הסופי לתשלום להזמנה
        /// </summary>
        /// <param name="order">ההזמנה שרוצים לחשב את הסכום</param>
        public void CalcTotalPrice(BO.Order order)
        {
            order.FinalPrice = (from p in order.ProductList
                                select p.FinalPriceProduct).Sum();
        }

        /// <summary>
        /// חישוב המחיר לתשלום עבור מוצר בהזמנה, כולל מימוש מבצעים
        /// </summary>
        /// <param name="product">המוצר שרוצים לחשב את המחיר</param>
        public void CalcTotalPriceForProduct(BO.ProductInOrder product)
        {
            int count = product.OrderQuantity;
            List<BO.SaleInProduct> listSalesUsed = new();
            foreach (BO.SaleInProduct sale in product.ListSales)
            {
                if (count >= sale.QuantitySale)
                {
                    product.FinalPriceProduct += ((count / sale.QuantitySale) * sale.Price);
                    count = count % sale.QuantitySale;
                    listSalesUsed.Add(sale);
                }
            }
            product.FinalPriceProduct += (count * product.BasePriceProduct);
            product.ListSales = listSalesUsed;
        }

        /// <summary>
        /// DALעבור כל מוצר בהזמנה, מייצרים בקשת עדכון ל 
        ///  כדי להוריד ממלאי המוצר את הכמות שבהזמנה
        /// </summary>
        /// <param name="order">ההזמנה שרוצים לעדכן</param>
        public void DoOrder(BO.Order order)
        {
            foreach (BO.ProductInOrder p in order.ProductList)
            {
                DO.Product product = _dal.Product.Read(p.IdProduct);
                _dal.Product.Update(product with { QuantityInStock = product.QuantityInStock - p.OrderQuantity });
            }
        }

        /// <summary>
        /// עדכון המבצעים המתאימים למוצר בהזמנה
        /// </summary>
        /// <param name="product">מוצר בהזמנה</param>
        /// <param name="existingCustomer">האם ההזמנה היא ללקוח קיים</param>
        public void SearchSaleForProduct(BO.ProductInOrder product, bool existingCustomer)
        {
            product.ListSales = _dal.Sale.ReadAll(
                sale => product.IdProduct == sale.Code
                && (existingCustomer == true || sale.Club == false)
                && DateTime.Now >= sale.startDate && DateTime.Now <= sale.FinishDate
                && product.OrderQuantity >= sale.Quantity)
            .Select(s => new BO.SaleInProduct()
            {
                IdSale = s.Id,
                ForAllCustomers = s.Club,
                Price = s.Price,
                QuantitySale = s.Quantity,
            }).ToList();
            product.ListSales.OrderBy(s => s.Price / s.QuantitySale);
        }
    }
}
