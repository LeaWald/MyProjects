using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    List<Customer> customers;
    private static string fileName = "../xml/customers.xml";

    private List<Customer> LoadCustomers()
    {
        if (File.Exists(fileName))
        {
            using (FileStream xmlReader = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return serializer.Deserialize(xmlReader) as List<Customer> ?? new List<Customer>();
            }
        }
        return new List<Customer>(); // אם הקובץ לא קיים, מאתחלים רשימה ריקה
    }

    private void SaveProducts(List<Customer> customers)
    {
        using (FileStream xmlWriter = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(xmlWriter, customers);
        }
    }
    public int Create(Customer cust)
    {
        customers = LoadCustomers();
        if (customers.Any(c => c.Id == cust.Id))
            throw new DalIdExist("id already exist");
        else
        {
            customers.Add(cust);
            SaveProducts(customers);
            LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create customer{cust}");
            return cust.Id;
        }
    }

    public void Delete(int id)
    {
        customers = LoadCustomers();
        Customer customer = Read(id);
        customers.Remove(customer);
        SaveProducts(customers);
        LogManager.WriteToLog("dalete", MethodBase.GetCurrentMethod().Name, $"delete customer{id}");
    }

    public Customer? Read(int id)
    {
        try
        {
            customers = LoadCustomers();
            LogManager.WriteToLog("read", MethodBase.GetCurrentMethod().Name, $"read customer {id}");
            return customers.First(c => c.Id == id);
        }
        catch
        {
            throw new DalIdNotExist("customer id not found");
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        return ReadAll(filter).FirstOrDefault(filter);
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        try
        {
            customers = LoadCustomers();
            LogManager.WriteToLog("read by param", MethodBase.GetCurrentMethod().Name, $"read customer who meet the condition");
            if (filter == null)
                return customers;
            return customers.Where(filter).ToList();
        }
        catch
        {
            throw new DalIdNotExist("customer id not found");
        }
    }

    public void Update(Customer cust)
    {
        try
        {
            customers = LoadCustomers();
            int index = customers.FindIndex(c => c.Id == cust.Id);
            customers[index] = cust;
            SaveProducts(customers);
            LogManager.WriteToLog("upDate", MethodBase.GetCurrentMethod().Name, $"upDate customer{cust.Id}");
        }
        catch
        {
            throw new DalIdNotExist("customer id not found");
        }
    }
}
