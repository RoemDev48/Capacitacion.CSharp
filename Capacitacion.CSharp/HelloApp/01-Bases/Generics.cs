partial class Program
{
    static void Generics()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        int[] numbers = { 1, 2, 3 };

        WriteLine("Length of names array: " + GetArrayLength(names));
        WriteLine("Length of numbers array: " + GetArrayLength(numbers));

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy texto" };
        numberBox.Show();
        stringBox.Show();
    }

    // methods without the use of generics
    // static int GetIntArrayLength(int[] array)
    // {
    //     return array.Length;
    // }

    // static string GetStringArrayLength(string[] array)
    // {
    //     return array.Length.ToString();
    // }

    // Generic method
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
    class Box<T>
    {
        public T? Content { get; set; }

        public void Show()
        {
            WriteLine($"Contenido: {Content}");
        }
    }
}
