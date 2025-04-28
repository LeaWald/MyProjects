
namespace DO;
/// <summary>
/// רשומה לפרטי מבצע
/// </summary>
/// <param name="Id">מספר מזהה של המבצע</param>
/// <param name="Code">מספר מזהה של מוצר</param>
/// <param name="Quantity">כמות נדרשת לקבלת המבצע</param>
/// <param name="Price">מחיר כולל מבצע</param>
/// <param name="Club">האם רק ללקוחות מועדון?</param>
/// <param name="startDate">תאריך תחילת המבצע</param>
/// <param name="FinishDate">תאריך סיום המבצע</param>
public record Sale
    (int Id, int? Code, int Quantity, double Price, bool? Club, DateTime? startDate, DateTime? FinishDate)
{
    public Sale() : this(0, 0, 0, 0, false, DateTime.Now, DateTime.Now)
    {

    }
}
