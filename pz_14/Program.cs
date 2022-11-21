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
        static int AllNumbers(int A, int B)
        {
            StringBuilder result = new StringBuilder("1");
            if (A == B)
            {
                return 1;
            }
            else if (A < B)
            {
                return AllNumbers(A + 1, B) + 1;
            }
            else
            {
                return AllNumbers(A - 1, B) - 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine(ArithProgress(9, 0.5, 5));
            Console.WriteLine("Задача 2");
            Console.WriteLine(GeomProgress(5, -0.1, 5));
            Console.WriteLine("Задача 3");
            Console.WriteLine(AllNumbers(5, 3));
        }
    }
}