namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //for (int i = 0; i < 60; i += 5)
            //{ 
            //    Console.WriteLine(i);
            //}

            // Задание 2
            //char symbol = 'e';
            //string result = "";
            //for (int i = 0; i < 5; i++)
            //{ 
            //   result += Convert.ToChar(symbol + i);
            //}
            //Console.WriteLine(result);

            // Задание 3
            //int n = 3;
            //int m = 6;
            //
            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine(String.Concat(Enumerable.Repeat('#', n)));
            //}

            // Задание 4
            //int value = 5;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % value == 0 || i % value == value)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // задание 5
            int i = 2;
            int j = 40;
            int difference = 18;

            for (; ;i++, j-- )
            {
                if ( j - i == difference)
                {
                    Console.WriteLine($"i = {i} \nj = {j}");
                    break;  
                }
            }
        }
    }
}