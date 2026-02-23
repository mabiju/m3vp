namespace a_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        float b = a; // implicit, automatic conversion
        // float b = (float)a; // explicit, type casting
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
