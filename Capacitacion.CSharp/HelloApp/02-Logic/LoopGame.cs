partial class Program
{
    static void LoopGame()
    {
        int count = 0;
        WriteLine("Welcome to the Loop Game!");
        WriteLine("Press any key to increase your score.\n Press 'esc' to quit.\n");
        while (true)
        {
            var key = ReadKey(true).Key;
            if( key == ConsoleKey.Escape)
            {
                WriteLine("Thanks for playing!, you are leaving with a score of: " + count);
                break;
            }
            count++;
            WriteLine($"Your score is: {count}");
        }
    }
}