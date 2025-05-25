namespace a_method_overriding;

class Dad
{
    public void hi()
    {
        Console.WriteLine("Hi Child.");
    }
}

class Child : Dad
{
    // public void hi()
    public new void hi()
    {
        Console.WriteLine("Hello Dad.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hi();
    }
}
