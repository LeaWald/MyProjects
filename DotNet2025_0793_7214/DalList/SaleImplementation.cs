namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;
using System.Linq;

internal class SaleImplementation : ISale
{
    /// <summary>
    /// יצירת מבצע חדש
    /// </summary>
    /// <param name="item">המבצע שרוצים ליצור</param>
    /// <returns>מחזיר את קוד המבצע החדש</returns>
    public int Create(Sale item)
    {
        Sale s = item with { Id = DataSource.Config.SaleCode };
        Product p = DataSource.Products.FirstOrDefault(p => p.Id == s.Code) ?? throw new Exception("product code not exist");
        DataSource.Sales.Add(s);
        LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create sale{s}");
        return s.Id;
    }

    /// <summary>
    /// מחיקת מבצע ע"י קוד מבצע
    /// </summary>
    /// <param name="id">קוד מבצע שרוצים למחוק</param>
    public void Delete(int id)
    {
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteToLog("delete", MethodBase.GetCurrentMethod().Name, $"delete sale{s}");

    }

    /// <summary>
    /// שליפת מבצע ע"י קוד
    /// </summary>
    /// <param name="id">קוד המבצע לשליפה</param>
    /// <returns>מחזיר את המבצע של הקוד שרוצים לשלוף</returns>
    /// <exception cref="DalIdNotExist">אם לא קיים הקוד שהתקבל</exception>
    public Sale? Read(int id)
    {
        try
        {
            Sale sale = DataSource.Sales.First(s => s.Id == id);
            LogManager.WriteToLog("read", MethodBase.GetCurrentMethod().Name, $"read sale{sale}");
            return sale;
        }
        catch
        {
            throw new DalIdNotExist("sale code not found");

        }
    }

    /// <summary>
    /// שליפת מבצע ע"י תנאי מסוים
    /// </summary>
    /// <param name="filter">תנאי הסינון</param>
    /// <returns>מחזיר את המבצע שנשלף</returns>
    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale sale = DataSource.Sales.FirstOrDefault(filter);
        LogManager.WriteToLog("read by param", MethodBase.GetCurrentMethod().Name, $"read sale{sale} who meet the condition");
        return sale;
    }

    /// <summary>
    /// שליפת כל המבצעים שעומדים בתנאי מסויים
    /// </summary>
    /// <param name="filter">תנאי הסינון</param>
    /// <returns>מחזיר רשימת מבצעים שעמדו בתנאי</returns>
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
        {
            LogManager.WriteToLog("read all", MethodBase.GetCurrentMethod().Name, $"read all sale{DataSource.Sales}");
            return new List<Sale?>(DataSource.Sales);
        }
        LogManager.WriteToLog("read all by param", MethodBase.GetCurrentMethod().Name, $"read all sale{DataSource.Sales} who meet the condition");
        return DataSource.Sales.Where(s => filter(s)).ToList();
    }

    /// <summary>
    /// עדכון מבצע
    /// </summary>
    /// <param name="item">מבצע שרוצים לעדכן</param>
    public void Update(Sale item)
    {
        Delete(item.Id);
        DataSource.Sales.Add(item);
        LogManager.WriteToLog("upDate", MethodBase.GetCurrentMethod().Name, $"upDate sale{item}");
    }
}

