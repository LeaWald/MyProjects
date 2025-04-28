using DalApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal;

 public class DalXml : IDal
{
    private static readonly DalXml instance = new DalXml();
    public static DalXml Instance { get { return instance; } }
    private DalXml() { }
    public IProduct Product => new ProductImplementation();

    public ISale Sale => new SaleImplementation();

    public ICustomer Customer => new CustomerImplementation();
}
