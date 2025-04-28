

using System.Runtime.CompilerServices;

namespace Dal;
using DO;

static internal class DataSource
{
    static internal List<Customer?> Customers = new List<Customer?>();
    static internal List<Product?> Products = new List<Product?>();
    static internal List<Sale?> Sales = new List<Sale?>();


    static internal class Config
    {

        internal const int ProductMinCode = 100;
        internal const int SaleMinCode = 200;

        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;
        public static int ProductCode
        {
            get
            {
                return ProductIndex++;
            }
        }

        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }
    }


}

