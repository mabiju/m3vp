namespace a_single_inheritance;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi from SuperClass");
    }
}
class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello from SubClass.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass s1 = new SubClass();
        s1.hi(); // method from super class 
        s1.hello();    // own method
    }
}
