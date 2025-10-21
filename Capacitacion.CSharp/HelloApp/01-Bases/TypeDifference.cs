partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x; // y is a copy of x
        y = 10; // Changing y does not affect x
        WriteLine($"x: {x}, y: {y}");
    
        Person person1 = new Person { Name = "Alice" };
        Person person2 = person1; // person2 references the same object as person1
        person2.Name = "Bob"; // Changing person2's Name affects person1
        WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}");
    }
}

class Person
{
    public string? Name { get; set; }
}