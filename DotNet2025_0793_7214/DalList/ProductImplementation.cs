
namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;
using System.Linq;

internal class ProductImplementation : IProduct
{
    /// <summary>
    /// יצירת מוצר חדש שהקוד שלו הוא מספור רץ
    /// </summary>
    /// <param name="item">מקבל מוצר</param>
    /// <returns>מחזיר את הקוד של המוצר שנוצר</returns>
    public int Create(Product item)
    {
        Product p = item with { Id = DataSource.Config.ProductCode };
        DataSource.Products.Add(p);
        LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create product{p}");
        return p.Id;
    }
    /// <summary>
    /// מחיקת מוצר ע"י הקוד
    /// </summary>
    /// <param name="id">מקבל קוד מוצר</param>
    public void Delete(int id)
    {
        Product p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.WriteToLog("delete", MethodBase.GetCurrentMethod().Name, $"delete product{id}");
    }
    /// <summary>
    /// שליפת מוצר ע" י קוד
    /// </summary>
    /// <param name="id">קוד מוצר</param>
    /// <returns>מחזיר את המוצר שנשלף</returns>
    /// <exception cref="DalIdNotExist">אם לא קיים הקוד שרוצים לשלוף</exception>
    public Product? Read(int id)
    {
        try
        {
            Product product = DataSource.Products.First(p => p.Id == id);
            LogManager.WriteToLog("read", MethodBase.GetCurrentMethod().Name, $"read product{product}");
            return product;
        }
        catch
        {
            throw new DalIdNotExist("product code not found");

        }
    }

    /// <summary>
    /// שליפת מוצר ע"י תנאי מסויים
    /// </summary>
    /// <param name="filter">תנאי הסינון</param>
    /// <returns>מחזיר את המוצר שנשלף</returns>
    public Product? Read(Func<Product, bool> filter)
    {
        Product product = DataSource.Products.FirstOrDefault(filter);
        LogManager.WriteToLog("read by param", MethodBase.GetCurrentMethod().Name, $"read product{product} who meet the condition");
        return product;
    }

    /// <summary>
    /// שליפת כל המוצרים ע"י תנאי מסוים
    /// </summary>
    /// <param name="filter">תנאי סינון</param>
    /// <returns>מחזיר את רשימת כל המוצרים שעמד בתנאי</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter == null)
        {
            LogManager.WriteToLog("read all by param", MethodBase.GetCurrentMethod().Name, $"read all product{DataSource.Products}");
            return new List<Product?>(DataSource.Products);
        }
        LogManager.WriteToLog("readAll", MethodBase.GetCurrentMethod().Name, $"read all product{DataSource.Products} who meet the condition");
        return DataSource.Products.Where(filter).ToList();
    }
    /// <summary>
    /// עדכון מוצר
    /// </summary>
    /// <param name="item">מוצר שרוצים לעדכן</param>
    public void Update(Product item)
    {
        Delete(item.Id);
        DataSource.Products.Add(item);
        LogManager.WriteToLog("upDate", MethodBase.GetCurrentMethod().Name, $"upDate product{item}");

    }
}
