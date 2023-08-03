using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<Day>\d{2})([-./])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
            string dates = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(dates);

            foreach (Match match in matches)
            {
                string day = match.Groups["Day"].Value;
                string month = match.Groups["Month"].Value;
                string year = match.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}