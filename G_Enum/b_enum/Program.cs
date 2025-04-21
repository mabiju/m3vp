namespace b_enum;

class Program
{
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    static void Main(string[] args)
    {
        var today = Days.Saturday;
        if (today == Days.Saturday || today == Days.Friday)
        {
            Console.WriteLine("Hello friends let's have fun.");
        }
        else
        {
            Console.WriteLine("Let's work guys.");
        }

    }
}
