partial class Program
{
    static void NumericTypes()
    {
        // Numeric variables types
        int integerNumber = 10; // Integer type 32 bits
        double doubleNumber = 3.14d; // Double type 64 bits, needs "d" suffix
        float floatNumber = 3.14f; // Float type 32 bits, needs "f" suffix, less precision than double but use less memory
        long longNumber = 12345678901234L; // Long type 64 bits, needs "L" suffix
        decimal decimalNumber = 19.99m; // Decimal type 128 bits, needs "m" suffix, used for financial calculations

        WriteLine("Integer Number: " + integerNumber);
        WriteLine("Double Number: " + doubleNumber);
        WriteLine("Float Number: " + floatNumber);
        WriteLine("Long Number: " + longNumber);
        WriteLine("Decimal Number: " + decimalNumber);
    }
}