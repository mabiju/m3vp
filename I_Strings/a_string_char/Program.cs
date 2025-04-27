namespace a_string_char;

class Program
{
    static void Main(string[] args)
    {
        // array of characters
        char[] namearray = { 'r', 'a', 'm' };
        string name = new string(namearray);
        Console.WriteLine(name);
    }
}
