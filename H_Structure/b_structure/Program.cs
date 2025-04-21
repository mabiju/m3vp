namespace b_structure;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string phone;
}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        Student s2;

        s1.roll = 11;
        s1.name = "Ram Thapa";
        s1.age = 23;
        s1.address = "Kathmandu";
        s1.phone = "1234567890";

        s2.roll = 12;
        s2.name = "Sita Rai";
        s2.age = 22;
        s2.address = "Pokhara";
        s2.phone = "0987654321";


        Console.WriteLine("Student 1 roll = " + s1.roll);
        Console.WriteLine("Student 1 name = " + s1.name);
        Console.WriteLine("Student 1 age = " + s1.age);
        Console.WriteLine("Student 1 address = " + s1.address);
        Console.WriteLine("Student 1 phone = " + s1.phone);

        Console.WriteLine();

        Console.WriteLine("Student 2 roll = " + s2.roll);
        Console.WriteLine("Student 2 name = " + s2.name);
        Console.WriteLine("Student 2 age = " + s2.age);
        Console.WriteLine("Student 2 address = " + s2.address);
        Console.WriteLine("Student 2 phone = " + s2.phone);
    }
}
