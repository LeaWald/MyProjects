using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DalXml;

internal static class Config
{
    private const string PMINCODE = "ProductMinCode";
    private const string SMINCODE = "SaleMinCode";
    private static string fileName = "../xml/data-config.xml";
    private static XElement dataFile = XElement.Load(fileName);
    public static int ProductMinCode
    {
        get
        {
            int prodMinCode = int.Parse(dataFile.Element(PMINCODE).Value);
            int currentMinCode = prodMinCode+1;
            dataFile.Element(PMINCODE).SetValue(currentMinCode);
            dataFile.Save(fileName);
            return prodMinCode;
        }
    }

    public static int SaleMinCode
    {
        get
        {
            int saleMinCode = int.Parse(dataFile.Element(SMINCODE).Value);
            int currentMinCode = saleMinCode + 1;
            dataFile.Element(SMINCODE).SetValue(currentMinCode);
            dataFile.Save(fileName);
            return saleMinCode;
        }
    }
}
