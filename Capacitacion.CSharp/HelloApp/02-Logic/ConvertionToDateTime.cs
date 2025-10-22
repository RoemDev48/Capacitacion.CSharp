using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        // Establish the culture to Spanish (Spain) for date formatting
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        int friends = int.Parse("15");
        DateTime birthday = DateTime.Parse("23 de Junio 1985");
        WriteLine($"i have {friends} friends and my birthday is {birthday}");
        WriteLine($"Largest date value: {birthday:D}");
    }
}