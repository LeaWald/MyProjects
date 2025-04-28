using DalApi;
using DalTest;
using DO;
using System.Data.Common;
using System.Threading.Channels;
using System.Xml;
using Tools;

internal class Program

{
    private static IDal s_dal = Factory.Get;
    public static int PrintMainMenu()
    {
        Console.WriteLine("For products press 1");
        Console.WriteLine("For sales press 2");
        Console.WriteLine("For customers press 3");
        Console.WriteLine("For clear log press 4");
        Console.WriteLine("For exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    public static int PrintSubMenu(string s)
    {
        Console.WriteLine($"To add {s}press 1");
        Console.WriteLine($"To read one {s}press 2");
        Console.WriteLine($"To read by papam {s}press 3");
        Console.WriteLine($"To read all {s}press 4");
        Console.WriteLine($"To update {s}press 5");
        Console.WriteLine($"To delete {s}press 6");
        Console.WriteLine("To exit press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Initialize data?, enter 1 else 2");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            Initialization.Initialize();
        try
        {
            int select1 = PrintMainMenu();

            while (select1 != 0)
            {
                switch (select1)
                {
                    case 1:
                        Console.WriteLine("product");
                        ProductMenu();
                        break;
                    case 2:
                        Console.WriteLine("sale");
                        SaleMenu();
                        break;
                    case 3:
                        Console.WriteLine("customer");
                        CustomertMenu();
                        break;
                    case 4:
                        LogManager.ClearLog();
                        break;
                    default:
                        Console.WriteLine("Worning selection. please select again");
                        break;
                }
                select1 = PrintMainMenu();

            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void ProductMenu()
    {
        int select;
        select = PrintSubMenu("product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    Product p = AddProduct();
                    int code = s_dal.Product.Create(p);
                    p = p with { Id = code };
                    break;
                case 2:
                    ReadOne(s_dal.Product);
                    break;
                case 3:
                    ReadParams(s_dal.Product, p => p.Price > 100);
                    break;
                case 4:
                    ReadAll(s_dal.Product.ReadAll(p => p.Price < 100));
                    break;
                case 5:
                    upDate("product");
                    break;
                case 6:
                    Delete(s_dal.Product);
                    break;
                default:
                    Console.WriteLine("Worning selection. please select again");
                    break;
            }
            select = PrintSubMenu("product");
        }
    }
    public static void SaleMenu()
    {
        int select;
        select = PrintSubMenu("sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    Sale s = AddSale();
                    int code = s_dal.Sale.Create(s);
                    s = s with { Id = code };
                    break;
                case 2:
                    ReadOne(s_dal.Sale);
                    break;
                case 3:
                    ReadParams(s_dal.Sale, q => q.Quantity > 2);
                    break;
                case 4:
                    ReadAll(s_dal.Sale.ReadAll());
                    break;
                case 5:
                    upDate("sale");
                    break;
                case 6:
                    Delete(s_dal.Sale);
                    break;
                default:
                    Console.WriteLine("Worning selection. please select again");
                    break;
            }
            select = PrintSubMenu("sale");
        }
    }
    public static void CustomertMenu()
    {
        int select;
        select = PrintSubMenu("customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    Customer c = AddCustomer();
                    int code = s_dal.Customer.Create(c);
                    c = c with { Id = code };
                    break;
                case 2:
                    ReadOne(s_dal.Customer);
                    break;
                case 3:
                    ReadParams(s_dal.Customer, c => c.CustomerName.Length > 5);
                    break;
                case 4:
                    ReadAll(s_dal.Customer.ReadAll(c => c.CustomerName.Length > 7));
                    break;
                case 5:
                    upDate("customer");
                    break;
                case 6:
                    Delete(s_dal.Customer);
                    break;
                default:
                    Console.WriteLine("Worning selection. please select again");
                    break;
            }
            select = PrintSubMenu("customer");
        }
    }
    private static void upDate(string s)
    {
        try
        {
            Console.WriteLine("enter code to update");
            int code = int.Parse(Console.ReadLine());
            if (s == "product")
            {
                Product p1 = s_dal.Product.Read(code);
                Product p2 = AddProduct();
                Product p3 = p2 with { Id = p1.Id };
                s_dal.Product.Update(p3);
            }
            if (s == "sale")
            {
                Sale s1 = s_dal.Sale.Read(code);
                Sale s2 = AddSale();
                Sale s3 = s2 with { Id = s1.Id };
                s_dal.Sale.Update(s3);
            }

            if (s == "customer")
            {
                Customer c1 = s_dal.Customer.Read(code);
                Customer c2 = AddCustomer();
                Customer c3 = c2 with { Id = c1.Id };
                s_dal.Customer.Update(c3);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine((e.Message));
        }
    }
    private static void Delete<T>(ICrud<T> iCrod)
    {
        try
        {
            Console.WriteLine("Enter code");
            int code = int.Parse(Console.ReadLine());
            iCrod.Delete(code);
            Console.WriteLine("Delete successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine((e.Message));
        }
    }
    private static Product AddProduct()
    {
        string ProductName;
        Categories Category;
        double Price;
        int QuantityInStock;
        Console.WriteLine("Enter the name of the product");
        ProductName = Console.ReadLine();
        Console.WriteLine("Enter the name of the categories between 1-5");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat)) Category = 0;
        else
            Category = (Categories)cat;
        Console.WriteLine("Enter price");
        if (!double.TryParse(Console.ReadLine(), out Price)) Price = 10;
        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out QuantityInStock)) QuantityInStock = 0;

        Product p = new Product(0, ProductName, Category, Price, QuantityInStock);

        Console.WriteLine("product create successfully");
        return p;
    }
    private static Sale AddSale()
    {
        int code;
        int Quantity;
        double Price;
        bool Club;
        DateTime startDate;
        DateTime FinishDate;


        Console.WriteLine("Enter the code of the product");
        if (!int.TryParse(Console.ReadLine(), out code)) code = 100;
        Console.WriteLine("Enter the quantity of sale that need buy");
        if (!int.TryParse(Console.ReadLine(), out Quantity)) Quantity = 1;
        Console.WriteLine("Enter price");
        if (!double.TryParse(Console.ReadLine(), out Price)) Price = 10;
        Console.WriteLine("only to club?");
        if (!bool.TryParse(Console.ReadLine(), out Club)) Club = false;
        Console.WriteLine("Enter date of start");
        if (!DateTime.TryParse(Console.ReadLine(), out startDate)) startDate = DateTime.Now;
        Console.WriteLine("Enter date of finish");
        if (!DateTime.TryParse(Console.ReadLine(), out FinishDate)) FinishDate = DateTime.Now;

        Sale s = new Sale(0, code, Quantity, Price, Club, startDate, FinishDate);

        Console.WriteLine("sale create successfully");

        return s;
    }
    private static Customer AddCustomer()
    {
        int code;
        string? CustomerName = "aaa";
        string? Address = "bbb";
        string Phone;

        Console.WriteLine("Enter code customer");
        if (!int.TryParse(Console.ReadLine(), out code)) code = 100;
        Console.WriteLine("Enter name customer");
        CustomerName = Console.ReadLine();
        Console.WriteLine("Enter address");
        Address = Console.ReadLine();
        Console.WriteLine("Enter phone");
        Phone = Console.ReadLine();

        Customer c = new Customer(code, CustomerName, Address, Phone);

        Console.WriteLine("Customer create successfully");
        return c;
    }
    private static void ReadAll<T>(List<T> list)
    {
        foreach (T t in list)
        {
            Console.WriteLine(t);
        }
    }
    private static void ReadOne<T>(ICrud<T> iCrod)
    {
        try
        {
            Console.WriteLine("Enter code");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(iCrod.Read(code));
        }
        catch (Exception e)
        {
            Console.WriteLine((e.Message));
        }

    }
    private static void ReadParams<T>(ICrud<T> iCrod, Func<T, bool> filter)
    {
        try
        {
            Console.WriteLine(iCrod.Read(filter));
        }
        catch (Exception e)
        {
            Console.WriteLine((e.Message));
        }
    }



}