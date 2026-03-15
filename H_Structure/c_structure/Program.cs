namespace c_structure;

struct Students
{
    public int roll;
    public string fullname;
    public string email;
    public string faculty;

    public void getDetails(int rn, string fn, string el, string fa)
    {
        roll = rn;
        fullname = fn;
        email = el;
        faculty = fa;
    }
    public void displayDetails()
    {
        Console.WriteLine("Roll number = {0}", roll);
        Console.WriteLine("Full Name = {0}", fullname);
        Console.WriteLine("Email Address = {0}", email);
        Console.WriteLine("Faculty = {0}", faculty);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Students s1 = new Students();
        Students s2 = new Students();
        s1.getDetails(12, "Ram Thapa", "ram@gmail.com", "Information Technology");
        s2.getDetails(13, "Sita Rai", "sita@gmail.com", "Business Studies");
        s1.displayDetails();
        Console.WriteLine();
        s2.displayDetails();
    }
}
