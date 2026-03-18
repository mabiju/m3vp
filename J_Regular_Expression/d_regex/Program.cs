namespace d_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"mi\b"; // \b : Matches if the specified characters are at the start or end of a string.
        string input = "The sanothimi campus";

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
