﻿namespace pz_7
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[12];
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-12, 12);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; ++i)
            {
                int temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                    arr[j] = arr[j - 1];
                arr[0] = temp;
            }
            Console.WriteLine("Произошел сдвиг на 4 элемента вправо");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
        }
    }
}