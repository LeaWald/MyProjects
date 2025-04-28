using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי לקוח
    /// </summary>
    /// <param name="Id">מס מזהה</param>
    /// <param name="CustomerName">שם לקוח</param>
    /// <param name="Address">כתובת</param>
    /// <param name="Phone">טלפון</param>
    public class Customer
    {
        public int Id { get; init;}
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
