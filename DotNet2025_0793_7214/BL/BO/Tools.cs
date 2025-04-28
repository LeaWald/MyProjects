using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BO;
internal static class Tools
{
    public static BO.Product convertToBoProduct(DO.Product prod)
    {
        try
        {
            BO.Product p = new BO.Product()
            {
                Id = prod.Id,
                ProductName = prod.ProductName,
                Category = (BO.Categories)prod.Category,
                Price = prod.Price,
                QuantityInStock = prod.QuantityInStock,
            };
            return p;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public static BO.Customer convertToBoCustomer(DO.Customer cust)
    {
        try
        {
            if (cust == null)
            {
                throw new ArgumentNullException("Customer null");
            }

            BO.Customer c = new BO.Customer()
            {
                Id = cust.Id,
                CustomerName = cust.CustomerName,
                Address = cust.Address,
                Phone = cust.Phone
            };
            return c;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static BO.Sale convertToBoSale(DO.Sale sale)
    {
        try
        {
            BO.Sale s = new BO.Sale()
            {
                IdSale = sale.Id,
                CodeProduct = sale.Code,
                Quantity = sale.Quantity,
                Price = sale.Price,
                Club = sale.Club,
                StartDate = sale.startDate,
                FinishDate = sale.FinishDate
            };
            return s;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static DO.Product convertToDoProduct(BO.Product prod)
    {
        try
        {
            DO.Product p = new DO.Product()
            {
                Id = prod.Id,
                ProductName = prod.ProductName,
                Category = (DO.Categories)prod.Category,
                Price = prod.Price,
                QuantityInStock = prod.QuantityInStock
            };
            return p;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public static DO.Customer convertToDoCustomer(BO.Customer cust)
    {
        try
        {
            DO.Customer c = new DO.Customer()
            {
                Id = cust.Id,
                CustomerName = cust.CustomerName,
                Address = cust.Address,
                Phone = cust.Phone
            };
            return c;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public static DO.Sale convertToDoSale(BO.Sale sale)
    {
        try
        {
            DO.Sale s = new DO.Sale()
            {
                Id = sale.IdSale,
                Code = sale.CodeProduct,
                Quantity = sale.Quantity,
                Price = sale.Price,
                Club = sale.Club,
                startDate = sale.StartDate,
                FinishDate = sale.FinishDate
            };
            return s;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static string ToStringProperty<T>(this T t)
    {
        string str = "";
        Type Ttype = t.GetType();
        PropertyInfo[] info = Ttype.GetProperties();
        foreach (PropertyInfo item in info)
        {
            if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
            {
                IEnumerable collection = item.GetValue(t) as IEnumerable;
                if (collection != null)
                {
                    foreach (var x in collection)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                {
                    str += string.Format("{0}: {1}  \n", item.Name, item.GetValue(t, null));
                }
            }
            else
                str += string.Format("{0}: {1}  \n", item.Name, item.GetValue(t, null));
        }
        return str;
    }

}
