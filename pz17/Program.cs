using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security.Claims;

namespace pz17
{
    internal class Program
    {
        int HP = 30;
        const int height = 20;
        const int width = 20;
        int power = 5;
        int step_counter = 0;
        char[,] map = new char[height, width];

        public string[] CreateCoords(string[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int first = rnd.Next(0, 20);
                int second = rnd.Next(0, 20);
                if (first != 9 && second != 9)
                {
                    string[] arr = (Convert.ToString(first) + " " + Convert.ToString(second)).Split();
                    array[i] = String.Join(" ", arr);
                }
                else
                {
                    first++;
                    second--;
                    string[] arr = (Convert.ToString(first) + " " + Convert.ToString(second)).Split();
                    array[i] = String.Join(" ", arr);
                }
            }
            return array;
        }

        public static void Main()
        {//основные вызовы методов
            Program P = new Program();
            P.GenerateMap();
            
            //while (P.HP != 0)
            //{
            //    P.UpdateMap();
            //}
        }
        public void GenerateMap() //генерация карты
        {
            Random rnd = new Random();
            string[] enemies = new string[10];
            string[] medicine = new string[5];
            string[] buffs = new string[3];

            // Генерируем карту
            for (int i = 0; i < map.Length / height; i++)
            {
                for (int j = 0; j < map.Length / width; j++)
                {
                    if (i == 9 && j == 9)
                    {
                        map[i, j] = 'P';
                    }
                    else
                    {
                        map[i, j] = '.';
                    }
                }
            }

            // Создаём список с координатами врагов
            CreateCoords(enemies);
            // добавление противников на карту
            for (int i = 0; i < enemies.Length; i++)
            {
                string t = String.Join(" ", enemies[i]);
                string[] coords = t.Split();
                map[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])] = 'E';
            }

            //создаём список с координатами аптечек
            CreateCoords(medicine);
            // добавление аптечек на карту
            for (int i = 0; i < medicine.Length; i++)
            {
                string t = String.Join(" ", medicine[i]);
                string[] coords = t.Split();
                map[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])] = 'M';
            }

            //создание списка с координатами бафов
            CreateCoords(buffs);
            // добавление бафов на карту
            for (int i = 0; i < buffs.Length; i++)
            {
                string t = String.Join(" ", buffs[i]);
                string[] coords = t.Split();
                map[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])] = 'B';
            }

            // Отрисовка карты
            for (int i = 0; i < map.Length / height; i++)
            {
                for (int j = 0; j < map.Length / width; j++)
                {
                    if (map[i, j] == 'P')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'B')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(map[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(map[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
        public void UpdateMap()
        {
            for (int i = 0; i < map.Length / height; i++)
            {
                for (int j = 0; j < map.Length / width; j++)
                {
                    if (map[i, j] == 'P')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(map[i, j]);
                    }
                    else if (map[i, j] == 'B')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(map[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(map[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }

        public static void Move(ConsoleKeyInfo key)
        {//перемещение

        }
        public static void Fight()
        {//обмен ударами игрока и врага до полной потери здоровья одним из них
        }
        public static void Healing()
        {// лечение
        }
        public static void Buff()
        {//увеличение силы
        }
        public static void SaveState()//сохра
        {
        }
    }
}