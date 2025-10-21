partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" }; // Create a list of strings
        names.Add("Diana"); // Add an element to the list
        names.Remove("Bob"); // Remove an element from the list
        WriteLine("Total names: " + names.Count); // Count property
        foreach (var name in names) // Iterate through the list
        {
            WriteLine("Name: " + name);
        }
        bool isPresent = names.Contains("Bob"); // Check if an element exists
        WriteLine("Is Bob present? " + isPresent);

        // Dictionary example
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };
        foreach (var student in students) // Iterate through the dictionary
        {
            WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
        WriteLine("Total students: " + students.Count); // Count property
        WriteLine("Student with ID 2: " + students[2]); // Accessing value by key
    }
}