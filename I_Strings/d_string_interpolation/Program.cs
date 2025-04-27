namespace d_string_interpolation;

class Program
{
    static void Main(string[] args)
    {
        // 1. use of $ symbol
        /* var name = "Ram";
        var gratitude = "Namaste";

        string greetings = $"{gratitude} sita ko buda {name}";
        Console.WriteLine(greetings); */

        /* var a = 5;
        string result = $"Squre of {a} = {a * a}";
        Console.WriteLine(result); */

        /* string name = "Ram";
        string message = $"Hello {name}";
        Console.WriteLine(message); */

        // 2. use of string.Format()
        string name = "Sita";
        string greetings = string.Format("Hello {0} {1}", name, " namaste");
        Console.WriteLine(greetings);
    }
}
