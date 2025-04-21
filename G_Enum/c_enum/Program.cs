namespace c_enum;

class Program
{
        
    static void Main(string[] args)
    {
        string name;
        Days day;
        Console.WriteLine("Enter name :");
        name = Console.ReadLine();
        Console.WriteLine("Enter the value from (0-6) for days:");
        int index = int.Parse(Console.ReadLine());
        day = (Days)index;
        Console.WriteLine("Hello " + name + " and day is " + day);
    }
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
}
