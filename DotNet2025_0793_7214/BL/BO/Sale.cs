using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי מבצע
    /// </summary>
    /// <param name="Id">מספר מזהה של המבצע</param>
    /// <param name="Code">מספר מזהה של מוצר</param>
    /// <param name="Quantity">כמות נדרשת לקבלת המבצע</param>
    /// <param name="Price">מחיר כולל מבצע</param>
    /// <param name="Club">האם רק ללקוחות מועדון?</param>
    /// <param name="StartDate">תאריך תחילת המבצע</param>
    /// <param name="FinishDate">תאריך סיום המבצע</param>
    public class Sale
    {
        public int IdSale { get; init; }
        public int? CodeProduct { get; init; }
        public int Quantity { get; init; }
        public double Price { get; init; }
        public bool? Club { get; init; }
        public DateTime? StartDate { get; init; }
        public DateTime? FinishDate { get; init; }
        public override string ToString() => this.ToStringProperty();

    }
}
