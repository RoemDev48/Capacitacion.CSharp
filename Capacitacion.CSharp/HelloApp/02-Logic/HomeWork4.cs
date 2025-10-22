partial class Program
{
    static void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }

    static void HomeWork4()
    {
        Console.Write("Enter a number to print its multiplication table: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            PrintMultiplicationTable(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120

    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }

    static void PrintFactorialTable()
    {
        Console.Write("Enter a number to print its factorial table: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}