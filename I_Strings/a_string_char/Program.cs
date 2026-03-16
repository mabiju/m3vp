namespace a_string_char;

class Program
{
    static void Main(string[] args)
    {
        // array of characters
        char[] myarray = { 'r', 'a', 'm' };
        string name = new string(myarray);
        Console.WriteLine(name);
    }
}
