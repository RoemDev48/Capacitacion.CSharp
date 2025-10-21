partial class Program
{
    static void Variables()
    {
        // can be declared the variable and assign the value later
        int edad;
        edad = 9;

        // or declare and assign the value in the same line
        // is recomended use pascalCase for types, properties and methods
        string nombre = "Juan";

        // CSharp is key sensitive, so "nombre" and "Nombre" are different variables
        // string Nombre = "Pedro";

        // Is a good practice to declare variables at the camelCase
        bool esEstudiante = true;

        WriteLine($"Nombre: {nombre}, Su edad es: {edad}, Es estudiante? {esEstudiante}");
    }
}