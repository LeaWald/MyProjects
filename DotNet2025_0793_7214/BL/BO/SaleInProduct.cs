using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה למבצע של מוצר
    /// </summary>
    /// <param name="IdSale">מס' מזהה של המבצע</param>
    /// <param name="QuantitySale">כמות למבצע</param>
    /// <param name="Price">מחיר</param>
    /// <param name="ForAllCustomers">מיועד לכל הלקוחות?</param>
    public class SaleInProduct
    {
        public int IdSale { get; set; }
        public int QuantitySale { get; set; }
        public double Price { get; set; }
        public bool? ForAllCustomers { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}
