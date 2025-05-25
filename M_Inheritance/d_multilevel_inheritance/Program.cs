namespace d_multilevel_inheritance;

public class A
{
    public int a = 23;
}
public class B : A
{
    public int b = 45;
}
public class C : B
{
    public int c = 67;

    public void sum()
    {
        Console.WriteLine("The sum = " + (a + b + c));
    }
}
class Program
{
    static void Main(string[] args)
    {
        C c1 = new C();
        c1.sum();
    }
}
