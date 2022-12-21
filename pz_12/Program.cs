using System.Security.Cryptography;

namespace pz_12
{
    internal class Program
    {
        static void ParallelogramArea(int h1, int side1, int h2, int side2)
        {
            if (h1*side1 > h2 * side2)
            {
                Console.WriteLine($"Наибольший параллелограм под номером 1.\nЕго площадь - {h1*side1}");
            }
            else
            {
                Console.WriteLine($"Наибольший параллелограм под номером 2.\nЕго площадь - {h2 * side2}");
            }
        }
        static void Main(string[] args)
        {
            ParallelogramArea(3, 4, 3, 6);
        }
    }
}