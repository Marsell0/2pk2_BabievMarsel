using System.Text.RegularExpressions;
namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\text.txt";
            string pattern = @"\d{1} ([А-Яа-я]+ [А-Яа-я]{0,} [А-Яа-я]{0,}) ?\+";
            Regex regex = new Regex(pattern);
            using (StreamReader sr = new StreamReader(path))
            {
                foreach (Match match in regex.Matches(sr.ReadToEnd()))
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}