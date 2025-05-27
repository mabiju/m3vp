namespace O_Encapsulation;

class Student
{
    private int roll;

    public int DisplayRoll(int a)
    {
        roll = a;
        return roll;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("Roll Number = " + s1.DisplayRoll(34));
    }
}
