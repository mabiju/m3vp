namespace c_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        int b = a;
        long c = a;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        // We can only assign the value of smaller data type to the larger data type.
    }
}
