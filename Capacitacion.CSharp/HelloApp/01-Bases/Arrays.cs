partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5]; // Declare an array of integers with 5 elements
        numbers[0] = 10; // Assign values to the array elements
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Direct initialization
        int[] numbersArray = { 1, 2, 3, 4, 5 };
        
        WriteLine("first element: " + numbers[0]); // Accessing elements with index
        WriteLine("second element: " + numbers[1]);
        WriteLine("third element: " + numbers[2]);
        WriteLine("fourth element: " + numbers[3]);
        WriteLine("fifth element: " + numbers[4]);

        WriteLine("the number of elements in the array: " + numbers.Length); // Length property

        // since final index is Length - 1 
        WriteLine("the last element in the array: " + numbers[numbers.Length - 1]);
        WriteLine("the last element in the array: " + numbers[^2]); // ^2 means the last element

        // ranges for obtaining a subset of the array
        int[] firstThreeNumbers = numbers[..3];
        // WriteLine("first three elements: " + string.Join(", ", firstThreeNumbers));

        int[] lastTwoNumbers = numbers[3..];
        // WriteLine("last two elements: " + string.Join(", ", lastTwoNumbers));

        foreach(var number in lastTwoNumbers)
        {
            WriteLine("number: " + number);
        }
    }
}