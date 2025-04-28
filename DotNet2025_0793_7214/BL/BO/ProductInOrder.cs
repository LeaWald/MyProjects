using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה להכנסת מוצר להזמנה
    /// </summary>
    /// <param name="IdProduct">מס' מזהה של המוצר</param>
    /// <param name="ProductName">שם מוצר</param>
    /// <param name="BasePriceProduct">מחיר בסיסי של מוצר</param>
    /// <param name="OrderQuantity">כמות מוצרים להזמנה</param>
    /// <param name="ListSales">רשימת מבצעים למוצר זה</param>
    /// <param name="FinalPriceProduct">מחיר סופי</param>
    public class ProductInOrder
        
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double BasePriceProduct { get; set; }
        public int OrderQuantity { get; set; }
        public List<BO.SaleInProduct> ListSales { get; set; }
        public double FinalPriceProduct { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}
