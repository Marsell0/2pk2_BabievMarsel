namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[7,7];
            int[] main = new int[7];
            int counter = 0;
            Random rnd = new Random();
            for (int i = 6; i >= 0; i--) 
            {
                for (int j = 6; j >= 0; j--)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Главная диагональ");
            for (int i = 0; i < 7; i++)
            {
                main[i] = arr[i, i];
                if (main[i] > 0)
                {
                    counter++;
                }
                Console.Write(main[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"количество положительных чисел: {counter}");
        }
    }
}