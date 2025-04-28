using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי מוצר
    /// </summary>
    /// <param name="Id">מס' מזהה</param>
    /// <param name="ProductName">שם מוצר</param>
    /// <param name="Category">קטגוריה</param>
    /// <param name="Price">מחיר</param>
    /// <param name="QuantityInStock">כמות במלאי</param>
    /// <param name="ListSales">רשימת מבצעים למוצר</param>

    public class Product
    {
        public int Id { get; init; }
        public string? ProductName { get; set; }
        public Categories? Category { get; set; }
        public double Price { get; set; }
        public int? QuantityInStock { get; set; }
        public List<BO.SaleInProduct> ListSales { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
