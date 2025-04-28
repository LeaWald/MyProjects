
namespace DO;
/// <summary>
/// רשומה לפרטי לקוח
/// </summary>
/// <param name="Id">מס מזהה</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="Address">כתובת</param>
/// <param name="Phone">טלפון</param>
public record Customer
    (int Id, string? CustomerName, string? Address, string Phone)
{
    public Customer() : this(0, null, null, "")
    {

    }
}
