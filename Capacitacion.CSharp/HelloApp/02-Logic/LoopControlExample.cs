partial class Program
{
    static void LoopControlExample()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // Exit the loop when i is 5
            }
            //WriteLine($"Current value: {i}");
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue; // Skip the rest of the loop when i is 5 or 7
            }
            //WriteLine($"Current value: {i}");
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                //return; // Exit the method when i is 3
            }
            //WriteLine($"Current value: {i}");
        }

        // infinite loop with break
        while (true)
        {
            WriteLine("This ever running loop will break immediately.");
            break; // Exit the infinite loop
        }
    }
}