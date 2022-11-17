using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection phoneNumbers = regex.Matches(text);

            string[] matchedPhoneNumbers = phoneNumbers.Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhoneNumbers));
        }
    } 
}
