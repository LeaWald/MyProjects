using DalApi;
using DalXml;
using DO;
using System.Reflection;
using System.Xml.Linq;
using Tools;

namespace Dal;

class SaleImplementation : ISale
{
    private const string LISTSALE = "ArrayOfSale";
    private const string SALE = "Sale";
    private const string ID = "Id";
    private const string CODE = "Code";
    private const string QUANTITY = "Quantity";
    private const string PRICE = "Price";
    private const string CLUB = "Club";
    private const string STARTDATE = "startDate";
    private const string FINISHDATE = "FinishDate";
    private static string fileSale = "../xml/sales.xml";
    private static string fileProduct = "../xml/products.xml";
    XElement mySale = XElement.Load(fileSale);
    XElement myProd = XElement.Load(fileProduct);
    public int Create(Sale sale)
    {
        if (!myProd.Descendants(ID).Any(p => int.Parse(p.Value) == sale.Code))
            throw new Exception("product code not exist");
        XElement newSale = new XElement(SALE,
            new XElement(ID, Config.SaleMinCode),
            new XElement(CODE, sale.Code),
            new XElement(QUANTITY, sale.Quantity),
            new XElement(PRICE, sale.Price),
            new XElement(CLUB, sale.Club),
            new XElement(STARTDATE, sale.startDate),
            new XElement(FINISHDATE, sale.FinishDate));
        mySale.Add(newSale);
        mySale.Save(fileSale);
        LogManager.WriteToLog("create", MethodBase.GetCurrentMethod().Name, $"create sale{sale.ToString}");
        return sale.Id;
    }

    public void Delete(int id)
    {
        try
        {
            XElement IdSale = mySale.Descendants(ID).Single(s => int.Parse(s.Value) == id);
            XElement SaleParent = IdSale.Parent;
            SaleParent.Remove();
            mySale.Save(fileSale);
            LogManager.WriteToLog("delete", MethodBase.GetCurrentMethod().Name, $"delete sale {id}");
        }
        catch
        {
            throw new DalIdNotExist("id sale not exist");
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            XElement IdSale = mySale.Descendants(ID).Single(s => int.Parse(s.Value) == id);
            XElement SaleParent = IdSale.Parent;
            Sale sale = new Sale()
            {
                Id = int.Parse(SaleParent.Element(ID).Value),
                Code = int.Parse(SaleParent.Element(CODE).Value),
                Quantity = int.Parse(SaleParent.Element(QUANTITY).Value),
                Price = double.Parse(SaleParent.Element(PRICE).Value),
                Club = bool.Parse(SaleParent.Element(CLUB).Value),
                startDate = DateTime.Parse(SaleParent.Element(STARTDATE).Value),
                FinishDate = DateTime.Parse(SaleParent.Element(FINISHDATE).Value),
            };
            return sale;
        }
        catch
        {
            throw new DalIdNotExist("sale code not found");
        }

    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            List<Sale?> sales = mySale.Elements().Select(
                s => new Sale()
                {
                    Id = int.Parse(s.Element(ID).Value),
                    Code = int.Parse(s.Element(CODE).Value),
                    Quantity = int.Parse(s.Element(QUANTITY).Value),
                    Price = double.Parse(s.Element(PRICE).Value),
                    Club = bool.Parse(s.Element(CLUB).Value),
                    startDate = DateTime.Parse(s.Element(STARTDATE).Value),
                    FinishDate = DateTime.Parse(s.Element(FINISHDATE).Value),
                }).Where(filter).ToList();
            LogManager.WriteToLog("read by param", MethodBase.GetCurrentMethod().Name, $"read sale who meet the condition");
            return sales.FirstOrDefault();
        }
        catch
        {
            throw new DalIdNotExist("sale not found");
        }
    }


    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            List<Sale?> sales = new List<Sale>();
            if (filter != null)
            {
                sales = mySale.Elements().Select(
                    s => new Sale()
                    {
                        Id = int.Parse(s.Element(ID).Value),
                        Code = int.Parse(s.Element(CODE).Value),
                        Quantity = int.Parse(s.Element(QUANTITY).Value),
                        Price = double.Parse(s.Element(PRICE).Value),
                        Club = bool.Parse(s.Element(CLUB).Value),
                        startDate = DateTime.Parse(s.Element(STARTDATE).Value),
                        FinishDate = DateTime.Parse(s.Element(FINISHDATE).Value),
                    }).Where(filter).ToList();
                LogManager.WriteToLog("read all", MethodBase.GetCurrentMethod().Name, $"read all sale on param");
            }
            else
            {
                sales = mySale.Elements().Select(
                    s => new Sale()
                    {
                        Id = int.Parse(s.Element(ID).Value),
                        Code = int.Parse(s.Element(CODE).Value),
                        Quantity = int.Parse(s.Element(QUANTITY).Value),
                        Price = double.Parse(s.Element(PRICE).Value),
                        Club = bool.Parse(s.Element(CLUB).Value),
                        startDate = DateTime.Parse(s.Element(STARTDATE).Value),
                        FinishDate = DateTime.Parse(s.Element(FINISHDATE).Value),
                    }).ToList();
                LogManager.WriteToLog("read all", MethodBase.GetCurrentMethod().Name, $"read all sale");
            }
            return sales;
        }
        catch
        {
            throw new DalIdNotExist("sale not found");
        }
    }

    public void Update(Sale sale)
    {
        try
        {
            if (!myProd.Descendants(ID).Any(p => int.Parse(p.Value) == sale.Code))
                throw new Exception("product code not exist");
            XElement IdSale = mySale.Descendants(ID).Single(s => int.Parse(s.Value) == sale.Id);
            XElement SaleParent = IdSale.Parent;
            SaleParent.SetElementValue(CODE, sale.Code);
            SaleParent.SetElementValue(QUANTITY, sale.Quantity);
            SaleParent.SetElementValue(PRICE, sale.Price);
            SaleParent.SetElementValue(CLUB, sale.Club);
            SaleParent.SetElementValue(STARTDATE, sale.startDate);
            SaleParent.SetElementValue(FINISHDATE, sale.FinishDate);
            mySale.Save(fileSale);
            LogManager.WriteToLog("update", MethodBase.GetCurrentMethod().Name, $"update sale {sale.Id}");
        }
        catch (InvalidOperationException)
        {
            throw new DalIdNotExist("sale code not found");
        }
    }
}
