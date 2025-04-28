using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DalTest;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        static void Main(string[] args)
        {
            Initialization.Initialize();
            try { 
            int select = 0;
            Console.WriteLine("enter id of customer or -1 to out");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 0;

            while (select != -1)
            {
                BO.Order order = new BO.Order();
                order.ProductList = new List<BO.ProductInOrder>();
                AddProduct(select, order);
                Console.WriteLine("enter id of customer or -1 to out");
                if (!int.TryParse(Console.ReadLine(), out select)) select = 0;
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddProduct(int select, BO.Order order)
        {
            try {
            int select2 = 0;
            Console.WriteLine("to add product enter 0 or -1 to out");
            if (!int.TryParse(Console.ReadLine(), out select2)) select2 = 0;
                while (select2 == 0)
                {
                    int id;
                    int quentity;
                    Console.WriteLine("enter id of product");
                    if (!int.TryParse(Console.ReadLine(), out id)) id = 100;
                    Console.WriteLine("enter quentity");
                    if (!int.TryParse(Console.ReadLine(), out quentity)) quentity = 1;

                    List<BO.SaleInProduct> listSale;
                    if (s_bl.Customer.IsCustomerExist(select))
                    {
                        order.PreferredCustomer = true;
                        listSale = s_bl.Order.AddProductToOrder(order, id, quentity);
                    }
                    else
                    {
                        order.PreferredCustomer = false;
                        listSale = s_bl.Order.AddProductToOrder(order, id, quentity);
                    }
                    foreach (BO.SaleInProduct sale in listSale)
                    {
                        Console.WriteLine("sale:");
                        Console.WriteLine(sale.ToString());
                    }
                    Console.WriteLine($"Final amount for the order so far:{order.FinalPrice}");

                    Console.WriteLine("to add product enter 0");
                    if (!int.TryParse(Console.ReadLine(), out select2)) select2 = 0;
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
