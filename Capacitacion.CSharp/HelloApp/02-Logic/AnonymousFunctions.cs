partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine($"Anonymous Functions Example: {square(5)}");
        WriteLine($"Lambda Expression Example: {squareLambda(5)}");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(x => x % 2 == 0);

        foreach (var num in evenNumbers)
        {
            WriteLine($"Even Number: {num}");
        }
    }

    static Func<int, int> square = delegate (int x)
    {
        return x * x;
    };

    // Using Lambda Expression
    // First int is the input type, second int is the return type
    static Func<int, int> squareLambda = x => x * x;
}