namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;

internal class CustomerImplementation : ICustomer
{
    /// <summary>
    /// הוספת לקוח
    /// </summary>
    /// <param name="item">לקוח שרוצים להוסיף</param>
    /// <returns>מחזיר את הקוד של הלקוח החדש</returns>
    /// <exception cref="Exception">אם קיים כבר הקוד</exception>
    public int Create(Customer item)
    {
        if (DataSource.Customers.Any(c => c.Id == item.Id))
        {
            throw new DalIdExist("customer code exist");
        }
        else
        {
            DataSource.Customers.Add(item);
            LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create customer{item}");
            return item.Id;
        }
    }
    /// <summary>
    /// מחיקת לקוח ע"י id
    /// </summary>
    /// <param name="id">קוד לקוח שרוצים למחוק</param>
    public void Delete(int id)
    {
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteToLog("dalete", MethodBase.GetCurrentMethod().Name, $"delete customer{c}");
    }
    /// <summary>
    /// שליפת לקוח לפי id 
    /// </summary>
    /// <param name="id">קוד לקוח שרוצים לקבל</param>
    /// <returns></returns>
    /// <exception cref="DalIdNotExist">שגיאה אם הקוד לא קיים</exception>
    public Customer? Read(int id)
    {
        try
        {
            Customer customer = DataSource.Customers.First(c => c.Id == id);
            LogManager.WriteToLog("read", MethodBase.GetCurrentMethod().Name, $"read customer{customer}");
            return customer;
        }
        catch
        {
            throw new DalIdNotExist("customer code not found");

        }
    }
    /// <summary>
    /// שליפת לקוח לפי תנאי מסוים
    /// </summary>
    /// <param name="filter">התנאי שעל פיו ישלף הלקוח</param>
    /// <returns> מחזיר את הלקוח הראשון שעומד בתנאי</returns>
    public Customer? Read(Func<Customer, bool> filter)
    {
        Customer customer = DataSource.Customers.FirstOrDefault(filter);
        LogManager.WriteToLog("read by param", MethodBase.GetCurrentMethod().Name, $"read customer{customer} who meet the condition");
        return customer;
    }

    /// <summary>
    /// שליפת כל הלקוחות שעומדים  בתנאי מסוים
    /// </summary>
    /// <param name="filter"> התנאי לשליפת לקוח</param>
    /// <returns>מחזיר רשימת כל הלקוחות שעומדים בתנאי</returns>
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        if (filter == null)
        {
            LogManager.WriteToLog("read all", MethodBase.GetCurrentMethod().Name, $"readAll customer{DataSource.Customers}");
            return new List<Customer?>(DataSource.Customers);
        }
        LogManager.WriteToLog("read all by param", MethodBase.GetCurrentMethod().Name, $"readAll customer{DataSource.Customers} who meet the condition");
        return DataSource.Customers.Where(filter).ToList();
    }
    /// <summary>
    /// עדכון לקוח
    /// </summary>
    /// <param name="item">לקוח שאותו רוצים לעדכן</param>
    public void Update(Customer item)
    {
        Delete(item.Id);
        DataSource.Customers.Add(item);
        LogManager.WriteToLog("upDate", MethodBase.GetCurrentMethod().Name, $"upDate customer{item}");

    }
}

