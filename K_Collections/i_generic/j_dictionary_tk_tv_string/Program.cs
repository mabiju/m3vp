namespace j_dictionary_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        // creating a dictionary using collection-initializer syntax
        var subjects = new Dictionary<string, string>()
        {
            {"Education","Nepali, Maths, English, Population"},
            {"Science","Biology, Chemistry, Physics, Maths"},
            {"Management","Business, Account, Finance, Economics"},
        };
        // Console.WriteLine(subjects["Education"]);
        // Console.WriteLine(subjects["Hunanities"]);

        /* if (subjects.ContainsKey("Education"))
        {
            Console.WriteLine(subjects["Education"]);
        } */
        if (subjects.ContainsKey("Humanities"))
        {
            Console.WriteLine(subjects["Humanities"]);
        }
    }
}
