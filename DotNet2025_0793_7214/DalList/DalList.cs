using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
namespace Dal
{
    sealed internal class DalList : IDal
    {
        public static readonly DalList instance = new DalList();
        public static DalList Instance { get { return instance; } }
        private DalList() { }
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();
        public ICustomer Customer => new CustomerImplementation();

    }
}
