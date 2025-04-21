namespace a_enum;

class Program
{
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    static void Main(string[] args)
    {
        int lastday = (int)Days.Saturday;
        Console.WriteLine(lastday);

        var wd = (Days)5;
        Console.WriteLine(wd);
    }
}
