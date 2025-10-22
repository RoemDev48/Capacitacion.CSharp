using Microsoft.VisualBasic;

partial class Program
{
    static void Tuples()
    {
        // how to declare a tuple?
        (int, string, bool) person = (1, "John Doe", true);
        WriteLine($"ID: {person.Item1}, Name: {person.Item2}, IsActive: {person.Item3}");

        (int Number, string Text, bool IsActive) anotherPerson = (1, "John Doe", true);
        WriteLine($"ID: {anotherPerson.Number}, Name: {anotherPerson.Text}, IsActive: {anotherPerson.IsActive}");

        var OperationResult = Operations(10, 5);
        WriteLine($"Sum: {OperationResult.sum}, Substract: {OperationResult.Substract}");

        (int Sum, int Sub) = Operations(10, 5);
        WriteLine($"Sum: {Sum}, Substract: {Sub}");
    }

    static (int sum, int Substract) Operations(int a, int b)
    {
        return (a + b, a - b); // returning a tuple
    }

}