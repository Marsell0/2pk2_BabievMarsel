using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace pz_14
{
    internal class Program
    {
        static double ArithProgress(double a1, double d, int n)
        {
            if (n == 1) 
            {
                return a1;
            }
            else 
            {
                return d + ArithProgress(a1, d, n-1);
            }
        }
        static double GeomProgress(double b1, double q, int n)
        { 
            if (n == 1) 
            {
                return b1;
            }
            else 
            {
                return q * GeomProgress(b1, q, n-1); 
            }
        }
        static string AllNumbers(int A, int B)
        {
            if (A == B)
            {
                return Convert.ToString(A);
            }
            else if (A > B)
            {
                return A + " " + AllNumbers(A - 1, B);
            }
            else {
                return A + " " + AllNumbers(A + 1, B);
            }
        }
        static void ReverseNums(int num)
        {
            int newNum = num % 10;
            Console.Write(newNum);
            num /= 10;
            if (num > 0)
            {
                ReverseNums(num);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine(ArithProgress(9, 0.5, 5));
            Console.WriteLine("Задача 2");
            Console.WriteLine(GeomProgress(5, -0.1, 5));
            Console.WriteLine("Задача 3");
            Console.WriteLine(AllNumbers(-2, 5));
            Console.WriteLine("Задача 4");
            ReverseNums(123);
        }
    }
}