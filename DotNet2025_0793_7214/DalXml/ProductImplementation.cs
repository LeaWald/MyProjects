using DalApi;
using DalXml;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    List<Product> products;
    private static string fileName = "../xml/products.xml";

    private List<Product> LoadProducts()
    {
        if (File.Exists(fileName))
        {
            using (FileStream xmlReader = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return serializer.Deserialize(xmlReader) as List<Product> ?? new List<Product>();
            }
        }
        return new List<Product>(); // אם הקובץ לא קיים, מאתחלים רשימה ריקה
    }

    private void SaveProducts(List<Product> products)
    {
        using (FileStream xmlWriter = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(xmlWriter, products);
        }
    }
    public int Create(Product prod)
    {
        products = LoadProducts();
        Product p = prod with { Id = Config.ProductMinCode };
        products.Add(p);
        SaveProducts(products);
        LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create product{p}");
        return p.Id;
    }

    public void Delete(int id)
    {
        products = LoadProducts();
        Product product = Read(id);
        products.Remove(product);
        SaveProducts(products);
        LogManager.WriteToLog("delete", MethodBase.GetCurrentMethod().Name, $"delete product{id}");
    }

    public Product? Read(int id)
    {
        try
        {
            products = LoadProducts();
            LogManager.WriteToLog("read", MethodBase.GetCurrentMethod().Name, $"read product{id}");
            return products.First(p => p.Id == id);
        }
        catch
        {
            throw new DalIdNotExist("product id not found");
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return ReadAll(filter).FirstOrDefault(filter);
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            products = LoadProducts();
            LogManager.WriteToLog("read by param or all", MethodBase.GetCurrentMethod().Name, $"read product");
            if (filter == null)
                return products;
            return products.Where(filter).ToList();
        }
        catch
        {
            throw new DalIdNotExist("product id not found");
        }
    }

    public void Update(Product item)
    {
        try
        {
            products = LoadProducts();
            int index = products.FindIndex(p => p.Id == item.Id);
            products[index] = item;
            SaveProducts(products);
            LogManager.WriteToLog("upDate", MethodBase.GetCurrentMethod().Name, $"upDate product{item}");
        }
        catch
        {
            throw new DalIdNotExist("product id not found");
        }

    }
}
