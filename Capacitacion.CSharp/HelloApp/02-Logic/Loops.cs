partial class Program
{
    static void Loops()
    {

        // While loop
        int count = 0;
        while (count < 5)
        {
            //WriteLine($"Count is: {count}");
            count++;
        }

        // do while loop
        // This loop will execute at least once
        int doCount = 0;
        do
        {
            //WriteLine($"Do Count is: {doCount}");
            doCount++;
        } while (doCount < 5);

        // For loop
        for (int i = 0; i < 5; i++)
        {
            //WriteLine($"For Loop iteration: {i}");
        }

        // perzonalized for loop
        for (int i = 10; i > 0; i -= 2)
        {
            WriteLine($"Personalized For Loop iteration: {i}");
        }

        // Foreach loop
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (var fruit in fruits)
        {
            //WriteLine($"Fruit: {fruit}");
        }

        List<string> names = ["Alice", "Bob", "Charlie"];
        foreach (var name in names)
        {
            //WriteLine($"Name: {name}");
        }
    }
}