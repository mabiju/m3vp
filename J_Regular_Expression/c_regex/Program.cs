namespace c_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\bThe"; // \b : Matches if the specified characters are at the start or end of a string.
        string input = "here is The sanothimi campus";

        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }
        else
        {
            Console.WriteLine("Input mismatched");
        }
    }
}
