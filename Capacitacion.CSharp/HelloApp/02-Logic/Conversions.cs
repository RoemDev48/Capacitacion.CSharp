partial class Program
{
    static void Conversions()
    {
        int intNumber = 42;
        double doubleNumber = intNumber; // Implicit conversion from int to double
        Console.WriteLine($"Implicit Conversion: int {intNumber} to double {doubleNumber}");

        double anotherDouble = 9.78;
        int anotherInt = (int)anotherDouble; // Explicit conversion from double to int
        Console.WriteLine($"Explicit Conversion: double {anotherDouble} to int {anotherInt}");

        string numberString = "123";
        int parsedInt = int.Parse(numberString); // Parsing string to int
        Console.WriteLine($"Parsed string '{numberString}' to int {parsedInt}");

        string invalidString = "abc";
        bool success = int.TryParse(invalidString, out int result); // Safe parsing
        if (success)
        {
            Console.WriteLine($"Successfully parsed '{invalidString}' to int {result}");
        }
        else
        {
            Console.WriteLine($"Failed to parse '{invalidString}' to int.");
        }
    }
}