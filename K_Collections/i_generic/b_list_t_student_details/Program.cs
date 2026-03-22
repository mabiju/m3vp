namespace b_list_t_student_details;

#nullable disable
public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student(){Roll = 420, Name = "Ram Thapa"},
            new Student(){Roll = 421, Name = "Sita Bhattarai"},
            new Student(){Roll = 423, Name = "Hari Poudel"},
            new Student(){Roll = 424, Name = "Tina Rai"},
            new Student(){Roll = 456, Name = "Mina Nepal"}
        };

        var StuNames =
            from s in students
                // where s.Name == "Hari Poudel"
            select s;

        foreach (var student in StuNames)
        {
            Console.WriteLine(student.Roll + " " + student.Name);
        }
    }
}
