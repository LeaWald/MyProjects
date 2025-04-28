
using System.Xml.Serialization;

namespace DO;
/// <summary>
/// רשומה לפרטי מוצר
/// </summary>
/// <param name="Id">מס' מזהה</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריה</param>
/// <param name="Price">מחיר</param>
/// <param name="QuantityInStock">כמות במלאי</param>
public record Product
    (int Id, string? ProductName, Categories? Category, double Price, int? QuantityInStock)

{
    public Product() : this(1, "gift", Categories.בנים, 50.3, 30)
    {

    }

}

