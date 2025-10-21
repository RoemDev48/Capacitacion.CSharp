partial class Program
{
    static void HomeWork1()
    {
        string product = "Laptop";
        int quantitySold = 5;
        double pricePerUnit = 799.99;
        double totalAmount = quantitySold * pricePerUnit;

        WriteLine("Product: " + product);
        WriteLine("Quantity Sold: " + quantitySold);
        WriteLine("Price per Unit: $" + pricePerUnit);
        WriteLine("Total Amount: $" + totalAmount);
    }

    // 🏆 Ejercicio:
    // Crear un programa que calcule el salario mensual de un trabajador
    // - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
    // - Calcular el sueldo y mostrarlo en pantalla
    static void SalaryCalculator()
    {
        WriteLine("Calculadora de Salario Mensual");

        string? name;
        int hoursWorked;
        double hourlyRate;

        do
        {
            Write("\nIngrese su nombre: ");
            name = ReadLine();
        } while (string.IsNullOrWhiteSpace(name));

        string? inputHours;
        while (true)
        {
            Write("Ingrese las horas trabajadas en el mes: ");
            inputHours = ReadLine();

            if (int.TryParse(inputHours, out hoursWorked) && hoursWorked >= 0)
                break;

            WriteLine("Ingrese un numero valido y mayor o igual a 0.");
        }

        string? inputRate;
        while (true)
        {
            Write("Ingrese la tarifa por hora: ");
            inputRate = ReadLine();

            if (double.TryParse(inputRate, out hourlyRate) && hourlyRate >= 0)
                break;

            WriteLine("Ingrese una tarifa valida y mayor o igual a 0.");
        }

        double monthlySalary = hoursWorked * hourlyRate;
        WriteLine($"\nHola {name}, su salario mensual es: ${monthlySalary:F2}");
    }
}