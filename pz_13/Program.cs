using System.Text;

namespace pz_13
{
    internal class Program
    {
        static int CountOf(string str, char subStr)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == subStr)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string text = "hello world";
            char subLine = 'l';
            Console.WriteLine(CountOf(text, subLine));
        }
    }
}