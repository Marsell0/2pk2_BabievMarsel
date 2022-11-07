using System.Text;
namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num;
            string[] arrText = text.Split();
            StringBuilder fin = new StringBuilder();
            foreach (string i in arrText)
            {
                try 
                {
                    num = Convert.ToInt32(i);
                    if (num > 9 || num < -9) 
                    {
                        fin.Append(Convert.ToString(i + " "));
                    }
                }
                catch 
                {
                    num = 0;
                }
            }
            Console.WriteLine(fin);
        }
    }
}