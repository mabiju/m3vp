namespace j_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string clz = "sanothimi";
        // string myClz = string.Copy(clz); // not recommend to use
        string myClz = new string(clz);
        Console.WriteLine("Original string = " + clz);
        Console.WriteLine("Copied string = " + myClz);
    }
}
