partial class Program
{
    static void Conditionals()
    {
        // If classic
        int age = 19;
        if (age >= 18)
        {
            WriteLine("Es mayor de edad");
        }
        else
        {
            WriteLine("Es menor");
        }

        // Ternary condition
        string message = age >= 18 ? "Es mayor de Edad" : "Es menor de Edad";

        // Condiciones Multiples
        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("Hace mucho calor.");
        }
        else if (temperature >= 20)
        {
            WriteLine("Es agradable");
        }
        else
        {
            WriteLine("Hace frío");
        }

        //Switch Case
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miércoles");
                break;
            default:
                WriteLine("Día no válido");
                break;
        }

        //Swicht case with expresions
        string dayMessage = day switch
            {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            _ => "Día no válido"
            };
            WriteLine(dayMessage);
    }
}