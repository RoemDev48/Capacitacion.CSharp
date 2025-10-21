partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(2002, 1, 28);
        TimeSpan difference = DateTime.Now - birthDate;
        
        WriteLine($"Has vivido {difference.Days} días.");
    }

    // 🏆 Ejercicio:
    // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
    // Consideraciones:
    // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
    //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
    // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
    // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
    //   sumando un año para calcular la fecha del próximo (opcional).
    static void DaysUntilNextBirthday()
    {
        DateTime birthDate;
        while (true)
        {
            Write("Enter your date of birth (format: dd/MM/yyyy): ");
            string? input = ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out birthDate))
                break;

            WriteLine("Invalid date. Please use the format dd/MM/yyyy.");
        }
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }
        TimeSpan timeUntilBirthday = nextBirthday - today;
        WriteLine($"There are {timeUntilBirthday.Days} days until your next birthday.");
    }
}