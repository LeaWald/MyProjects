using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        int Create(BO.Product item);
        BO.Product? Read(int id);
        List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null);
        void Update(BO.Product item);
        void Delete(int id);
        //מחזירה רשימת מבצעים שבתוקף למוצר לפי קוד מוצר והאם לקוח מועדף
        List<BO.SaleInProduct> PromotionsInEffect(int idProduct,bool favorite);
      

    }
}
