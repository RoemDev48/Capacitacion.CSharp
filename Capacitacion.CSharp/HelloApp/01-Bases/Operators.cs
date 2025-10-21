partial class Program
{
    static void Operators()
    {
        int number = 15;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            WriteLine($"{number} is even and greater than 10.");
        }
        else if (!isEven || isGreaterThanTen)
        {
            WriteLine($"{number} is either odd or greater than 10.");
        }
        else
        {
            WriteLine($"{number} is not even and not greater than 10.");
        }

        // Ternary operator use "?" and ":"
        int age = 21;
        string category = age >= 18 ? "Adult" : "Minor";
        WriteLine($"Age category: {category}");
    }
}