using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security.Claims;

namespace pz17
{
    internal class Program
    {
        int HP = 30;
        int power = 5;
        int step_counter = 0;
        char[,] map = new char[20, 20];
        public static void Main()
        {//основные вызовы методов
            Program P = new Program();
            P.GenerateMap();
         //while (Program.HP != 0)
         //{ 
         //  UpdateMap();

         //}
        }
        public void GenerateMap() //генерация карты
        {
            // Генерируем карту
            int count = 10;
            string b;
            for (int i = 0; i < map.Length / 20; i++)
            {
                for (int j = 0; j < map.Length / 20; j++)
                {
                    if (i == 9 && j == 9)
                    {
                        map[i, j] = 'P';
                    }
                    else
                    {
                        map[i, j] = '*';
                    }
                }
            }

            // Создаём список с коорднатами врагов
            Random rnd = new Random();
            string[] enemies = new string[10];
            for (int i = 0; i < enemies.Length; i++)
            {
                int first = rnd.Next(0, 20);
                int second = rnd.Next(0, 20);
                if (first != 9 && second != 9)
                {
                    string[] arr = (Convert.ToString(first) + " " + Convert.ToString(second)).Split();
                    enemies[i] = String.Join(" ", arr);
                    Console.WriteLine(enemies[i]);
                }
                else
                {
                    first++;
                    second--;
                    string[] arr = (Convert.ToString(first) + " " + Convert.ToString(second)).Split();
                    enemies[i] = String.Join(" ", arr);
                    Console.WriteLine(enemies[i]);
                }
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                string t = String.Join(" ", enemies[i]);
                string[] coords = t.Split();
                Console.ForegroundColor = ConsoleColor.Red;
                map[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])] = 'E';
            }
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < map.Length / 20; i++)
            {
                for (int j = 0; j < map.Length / 20; j++)
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
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(map[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
        public static void UpdateMap()
        {//обновление карты после действий
        }
        public static void Move(char direction)
        {//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
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