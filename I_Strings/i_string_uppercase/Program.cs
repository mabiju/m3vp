namespace i_string_uppercase;

class Program
{
    static void Main(string[] args)
    {
        string stringone = "HelloSanoTHIMi";
        string stringtwo = stringone.ToUpper();

        Console.WriteLine("Original string = " + stringone);
        Console.WriteLine("Converted uppercase string = " + stringtwo);
    }
}
