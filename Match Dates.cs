using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string datesToValidate = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(-|\/|\.)(?<month>[A-Z][a-z]+)\1(?<year>\d{4})";
            Regex regex = new Regex(pattern);
            MatchCollection validDates = regex.Matches(datesToValidate);
            foreach (Match validDate in validDates)
            {
                Console.WriteLine($"Day: {validDate.Groups[2]}, Month: {validDate.Groups[3]}, Year: {validDate.Groups[4]}");
                Console.WriteLine($"Day: {validDate.Groups["day"].Value}, Month: {validDate.Groups["month"].Value}, Year: {validDate.Groups["year"].Value}");
            } 
        }
    }
}
