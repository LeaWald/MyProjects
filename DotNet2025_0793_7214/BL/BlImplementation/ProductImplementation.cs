using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            return _dal.Product.Create(BO.Tools.convertToDoProduct(item));
        }

        public void Delete(int id)
        {
            _dal.Product.Delete(id);
        }


        public BO.Product Read(int id)
        {
            try
            {
                return BO.Tools.convertToBoProduct(_dal.Product.Read(id));
            }
            catch
            {
                throw new BO.BLIdNotExist("product code not found");
            }
        }

        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            if (filter == null)
            {
                return _dal.Product.ReadAll().Select(p => BO.Tools.convertToBoProduct(p)).ToList();
            }
            return _dal.Product.ReadAll(prod => filter(BO.Tools.convertToBoProduct(prod)))
            .Select(p => BO.Tools.convertToBoProduct(p)).ToList();
        }

        public void Update(BO.Product item)
        {
            DO.Product p = BO.Tools.convertToDoProduct(item);
            _dal.Product.Update(p);
        }

        public List<BO.SaleInProduct> PromotionsInEffect(int idProduct, bool favorite)
        {
            return _dal.Sale.ReadAll(sale => idProduct == sale.Id && (favorite == true || sale.Club == false) && DateTime.Now >= sale.startDate && DateTime.Now <= sale.FinishDate)
                .Select(s => new BO.SaleInProduct()
                {
                    IdSale = s.Id,
                    ForAllCustomers = s.Club,
                    Price = s.Price,
                    QuantitySale = s.Quantity,
                }).ToList();
        }
    }
}

