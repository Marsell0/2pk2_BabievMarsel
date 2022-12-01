using System.Xml.Schema;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 5
            //int count = 0;
            //string result = "";
            //string path = @"D:\some_text\text.txt";
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line = "";
            //    while (!sr.EndOfStream)
            //    {
            //        line = sr.ReadLine();
            //        string[] arr = line.Split();
            //        if (count < arr.Length)
            //        { 
            //            count = arr.Length;
            //            result = String.Join(" ", arr);
            //        }
            //    }
            //    Console.WriteLine(result);
            //}

            // Задание 28
            string path = @"D:\some_text\";
            string file_for_copy = "needable_file_for_work.txt";
            Console.WriteLine("Введите название файла");
            string S = $"{Console.ReadLine()}.txt";
            int count = 10000000;
            using (FileStream fs = new FileStream(path + file_for_copy, FileMode.OpenOrCreate)) // Создание файла и получение текста пользователя
            {
                Console.WriteLine("Вводите текст. Для прекращения ввода напишите \"s\"");
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    while (true) 
                    {
                        string line = Console.ReadLine();
                        if (line == "s")
                        {
                            break;
                        }
                        else 
                        {
                            string[] arr = line.Split();
                            if (count > arr.Length) // Сразу ищем самую маленькую строку
                            { 
                                count = arr.Length;
                            }
                            sw.WriteLine(line);
                        }
                    }

                }
            }

            using (FileStream fs = new FileStream(path + S, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(path + file_for_copy))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] arr = line.Split();
                            for (int i = 0; i < count ; i++)
                            {
                                sw.Write(arr[i] + " ");
                            }
                            sw.WriteLine();
                        }

                }
                Console.WriteLine("Завершено.");
            }
            File.Delete(path + file_for_copy);

        }
    }
}