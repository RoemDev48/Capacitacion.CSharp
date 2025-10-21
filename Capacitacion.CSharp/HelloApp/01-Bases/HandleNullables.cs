partial class Program
{
    static void HandleNullables()
    {
        string firstName = "John"; // is not nullable
        string? middleName = null; // is nullable

        WriteLine($"First Name: {firstName}");
        WriteLine($"Middle Name: {middleName ?? "Middle name not provided"}"); 
    }
}