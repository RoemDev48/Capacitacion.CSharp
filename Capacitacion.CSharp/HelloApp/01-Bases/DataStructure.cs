partial class Program
{
    static void DataStructures()
    {
        User pedro = new User { Name = "Pedro", Age = 30 };
        pedro.Greet();

        Point point = new Point(10, 20);
        point.Display();
        
        CellPhone myPhone = new CellPhone("Apple", "iPhone 13");
        WriteLine(myPhone);
    }
}

// Use a class for complex data with behavior
class User
{
    public string? Name { get; set; }
    public int? Age { get; set; }

    public void Greet()
    {
        WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

// Use a struct for lightweight data
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        WriteLine($"Point coordinates: ({X}, {Y})");
    }
}

// Use a record for immutable data
record CellPhone(string Brand, string Model);