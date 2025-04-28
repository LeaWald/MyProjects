

namespace DalTest;
using DO;
using DalApi;


public static class Initialization
{
    //private static IProduct? _dalProduct;
    //private static ISale? _dalSale;
    //private static ICustomer? _dalCustomer;
    private static IDal s_dal;
    private static List<int> productsCode = new List<int>();
    public static void creatProducts()
    {
        productsCode.Add(s_dal.Product.Create(new Product(0, "שעון יוקרתי", Categories.בית, 50, 20)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מחזיק חריטת שם", Categories.בנות, 14, 5)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "קרם גוף", Categories.כלות, 15, 16)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "בקבוק נירוסטה איכותי", Categories.יום_הולדת, 40, 11)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "אוטו על שלט", Categories.בנים, 100, 4)));
    }

    public static void creatSales()
    {
        s_dal.Sale.Create(new Sale(0, productsCode[0], 3, 10, false, DateTime.Today, DateTime.Today.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, productsCode[1], 4, 20, true, DateTime.Today, DateTime.Today.AddDays(10)));
        s_dal.Sale.Create(new Sale(0, productsCode[2], 3, 10, false, DateTime.Today, DateTime.Today.AddDays(15)));
        s_dal.Sale.Create(new Sale(0, productsCode[3], 2, 10, false, DateTime.Today, DateTime.Today.AddDays(4)));
        s_dal.Sale.Create(new Sale(0, productsCode[4], 7, 100, true, DateTime.Today, DateTime.Today.AddDays(2)));

    }
    public static void creatCustomers()
    {
        s_dal.Customer.Create(new Customer(12, "משה כהן", "רבי עקיבא 50", "0548444444"));
        s_dal.Customer.Create(new Customer(13, "אבי לוי", "הזית", "0548411111"));
        s_dal.Customer.Create(new Customer(14, "יהודה פרידמן", "התמר 85", "0548400000"));
        s_dal.Customer.Create(new Customer(15, "יוסי", "רשבי 8", "0548422222"));
        s_dal.Customer.Create(new Customer(16, "שרה שפירא", "אבני נזר 108", "0548499999"));

    }

    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;

        creatProducts();
        creatSales();
        creatCustomers();
        

    }
}

