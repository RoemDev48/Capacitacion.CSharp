partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
        {
            return "Positive";
        }
        else if (number < 0)
        {
            return "Negative";
        }
        else
        {
            return "Zero";
        }
    }

    static void Functions()
    {
        double area = CalculateArea(5.0, 10.0);
        Console.WriteLine($"Area: {area}");

        var EvaluateNumberResult = EvaluateNumber(-3);
        Console.WriteLine($"The number is: {EvaluateNumberResult}");
    }
}