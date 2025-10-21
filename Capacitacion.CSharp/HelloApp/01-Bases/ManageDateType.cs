using System.Data;

partial class Program
{
    static void ManageDateType()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7); // One week ago
        DateTime nextWeek = now.AddDays(7); // Next week
        DateTime customDate = new DateTime(2025, 12, 25); // Christmas 2025

        DayOfWeek WeekDay = now.DayOfWeek; // Current day of the week

        WriteLine($"Now: {now}");
        WriteLine($"Today: {today}");
        WriteLine($"One Week Ago: {oneWeekAgo.ToString("MM/dd/yyyy")}"); // is possible to format the output 
        WriteLine($"Next Week: {nextWeek}");
        WriteLine($"Custom Date (Christmas 2025): {customDate}");
        WriteLine($"Day of the Week: {WeekDay}");
    }
}