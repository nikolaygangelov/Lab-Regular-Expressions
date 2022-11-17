using System;

namespace _1._Match_Full_Name
{
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string listOfNames = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matches = Regex.Matches(listOfNames, pattern);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
