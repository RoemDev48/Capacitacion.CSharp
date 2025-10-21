partial class Program
{
    static void StringTypes()
    {
        // String variables types
        string name = "Rodrigo";
        string greeting = "Hello," + name; // String concatenation
        string interpolatedGreeting = $"Hello {name}"; // String interpolation

        WriteLine(greeting);
        WriteLine(interpolatedGreeting);
        // String propertys
        WriteLine($"The length of the name is: {name.Length}"); 
        WriteLine($"The name in uppercase is: {name.ToUpper()}");
        WriteLine($"The name in lowercase is: {name.ToLower()}");

        int number = 123;
        WriteLine($"The number as string is: {number.ToString()}");
        WriteLine($"The number as string is: {number}");

        bool isActive = true;
        WriteLine($"The boolean value is: {isActive.ToString()}");
        WriteLine($"The boolean value is: {isActive}");
    }
}