namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] arr = new int[8][];
            int[] lastElem = new int[8];
            int[] maxElem = new int[8];
            int[] midElem = new int[8];
            int count = 0;
            int middle;
            Console.WriteLine("Задание 1 и 2");
            for (int i = 0; i < 8; i++)
            {
                middle = 0;
                arr[i] = new int[rnd.Next(1, 10)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(0, 100);
                    middle += arr[i][j]; // Сразу начинаем вычислять среднее значение строки для задания 7
                    Console.Write(arr[i][j] + " ");
                    if (j == arr[i].Length - 1)
                    {
                        lastElem[count] = arr[i][j]; // Добавляем в массив последнюю строку для задания 3
                        count++;
                    }
                }
                midElem[i] = middle / arr[i].Length;
                Console.WriteLine();

            }
            count = 0;

            Console.WriteLine("\nЗадание 3"); // 3

            foreach (int i in lastElem)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nЗадание 4"); // 4

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > count)
                    {
                        count = arr[i][j];

                    }
                }
                maxElem[i] = count;
                count = 0;
            }
            foreach (int i in maxElem)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nЗадание 5");

            count = 0;
            int max = 0;
            int first = 0;
            for (int i = 0; i < 8; i++)
            {
                max = maxElem[i];
                first = arr[i][0];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == max)
                    {
                        arr[i][0] = max;
                        arr[i][j] = first;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадание 6");
            count = 0;
            int val = 0;
            for (int a = 0; a < 8; a++)
            {
                for (int i = 0, j = arr[a].Length - 1; i < j; i++, j--)
                {
                    val = arr[a][i];
                    arr[a][i] = arr[a][j];
                    arr[a][j] = val;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            count = 0;
            Console.WriteLine("\nЗадание 7");
            foreach (int i in midElem)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}