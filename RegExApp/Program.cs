using System.Text.RegularExpressions;

namespace RegExApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string date = "02-07-2026";
        TestGroups(date);
    }

    public static bool TestStringPattern(string? s)
    {
        if (s == null)
        {
            return false;
        }
        string pattern = @"^coding$"; //example pattern to match the string "coding"
        bool isMatch = Regex.IsMatch(s, pattern);
        return isMatch;
    }

    public static void TestMatch (string? s)
    {
        if (s is null) return;
        string pattern = @"^coding$";
        Match match = Regex.Match(s, pattern);
        if (match.Success)
        {
            Console.WriteLine($"Match found: {match.Value}");
        }
        else
        {
            Console.WriteLine("No match found.");
        }
    }

    public static void TestMatchers(string? s)
    {
        if (s is null) return;
        string pattern = @"\d+";
        MatchCollection matches = Regex.Matches(s, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void TestGroups(string? s)
    {
        if(s is null) return;
        string pattern = @"(\d{2})-(\d{2})-(\d{4})"; // matches two consecutive digits-\d{2
        MatchCollection matches = Regex.Matches(s, pattern);
        foreach (Match match in matches)
        {
            for (int i = 1; i < match.Groups.Count; i++)
            {
                Console.WriteLine($"Group {i}: {match.Groups[i].Value}");
            }
        }

    }

    public static void MapToGrDate(string? s)
    {
        if (s is null) return;

        //MM-DD-YYYY US FORMAT
        string pattern = @"(\d{2})-(\d{2})-(\d{4})";
        MatchCollection matches = Regex.Matches(s, pattern);
        foreach (Match match in matches)
        {
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;


            string grDate = $"{day}/{month}/{year}";
            Console.WriteLine($"{match.Value} -> {grDate}");
        }
    }

    //Zero-Length assertions
    public static bool TestPassword(string? s)
    {return Regex.IsMatch(s , "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*]).{12,}$");

    }
}
