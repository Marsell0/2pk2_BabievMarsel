using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security.Claims;

namespace pz17
{
    internal class Program
    {
        const int height = 20;
        const int width = 20;

        string path_for_save = @"D:\game_save.txt";

        bool gameFlag = true;
        bool buffFlag = false;

        int playerHP = 30;
        int enemyHP = 15;

        int player_punch_force = 5;
        int enemy_punch_force = 5;

        int step_counter = 0;
        int buff_counter = 5;
        int enemy_counter = 10;

        char[,] map = new char[height, width];
        int[] player_position = new int[2] { 9, 9 };
        string[] enemies = new string[10];
        string[] medicine = new string[5];
        string[] buffs = new string[3];

        public string[] CreateCoords(string[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int first = rnd.Next(0, 20);
                int second = rnd.Next(0, 20);
                if (first != 9 && second != 9)
                {
                    // пользуемся своеобразным костылём для корректной записи координат в массив
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
            if (File.Exists(P.path_for_save))
            {
                Console.WriteLine("У вас есть сохранение. Хотите загрузить?(введите цифру) \n 1. Да \n 2. Нет");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    P.LoadState();
                }
                else 
                {
                    P.GenerateMap();
                }
                Console.Clear();
            }
            while (P.gameFlag)
            {
                if (P.buffFlag)
                {
                    P.buff_counter--;
                }

                if (P.enemy_counter == 0)
                {
                    P.gameFlag = false;
                }
                if (P.playerHP <= 0)
                {
                    P.gameFlag = false;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                P.Move(key.Key);
                P.SaveState(key.Key);
                P.step_counter++;
                if (P.buff_counter == 0)
                {
                    P.player_punch_force = 5;
                    P.buffFlag = false;
                    P.buff_counter = 5;
                }
                foreach (string i in P.enemies)
                {
                    string[] coords_b = i.Split();
                    if (P.player_position[0] == Convert.ToInt32(coords_b[0])
                        && P.player_position[1] == Convert.ToInt32(coords_b[1]))
                    {
                        P.Fight();
                    }
                }
                foreach (string i in P.medicine)
                {
                    string[] coords_b = i.Split();
                    if (P.player_position[0] == Convert.ToInt32(coords_b[0])
                        && P.player_position[1] == Convert.ToInt32(coords_b[1]))
                    {
                        P.Healing();
                    }
                }
                foreach (string i in P.buffs)
                {
                    string[] coords_b = i.Split();
                    if (P.player_position[0] == Convert.ToInt32(coords_b[0])
                        && P.player_position[1] == Convert.ToInt32(coords_b[1]))
                    {
                        P.Buff();
                    }
                }
                P.UpdateMap();
            }
            Console.Clear();
            if (P.playerHP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Увы, вы проиграли. \n Количество ходов: {P.step_counter}");
            }
            else if (P.enemy_counter == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Поздравляем! Вы победили! \n Количество ходов: {P.step_counter}");
            }
        }
 

            
        public void GenerateMap() //генерация карты
        {
            Random rnd = new Random();

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
            Console.Clear();
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
            Console.WriteLine($"Количество ходов: {step_counter}");
            Console.WriteLine($"Количество врагов: {enemy_counter}");
            Console.WriteLine($"Здоровье: {playerHP}");
            Console.WriteLine($"Сила атаки: {player_punch_force}");
            if (buffFlag)
            {
                Console.WriteLine($"До конца усиления: {buff_counter}");
            }
        }

        public void Move(System.ConsoleKey direction)
        {//перемещение
            switch (direction)
            {
                case ConsoleKey.UpArrow:
                    player_position[0] -= 1;
                    if (player_position[0] < 0)
                    {
                        player_position[0] = 0;
                    }
                    map[player_position[0] + 1, player_position[1]] = '.';
                    map[player_position[0], player_position[1]] = 'P';
                    break;

                case ConsoleKey.DownArrow:
                    player_position[0] += 1;
                    if (player_position[0] > 19)
                    {
                        player_position[0] = 19;
                    }
                    map[player_position[0] - 1, player_position[1]] = '.';
                    map[player_position[0], player_position[1]] = 'P';
                    break;

                case ConsoleKey.LeftArrow:
                    player_position[1] -= 1;
                    if (player_position[1] < 0)
                    {
                        player_position[1] = 0;
                    }
                    map[player_position[0], player_position[1] + 1] = '.';
                    map[player_position[0], player_position[1]] = 'P';
                    break;

                case ConsoleKey.RightArrow:
                    player_position[1] += 1;
                    if (player_position[1] > 19)
                    {
                        player_position[1] = 19;
                    }
                    map[player_position[0], player_position[1] - 1] = '.';
                    map[player_position[0], player_position[1]] = 'P';
                    break;
            }
        }
        public void Fight()
        {//обмен ударами игрока и врага до полной потери здоровья одним из них
            while (enemyHP > 0)
            {
                playerHP -= enemy_punch_force;
                enemyHP -= player_punch_force;
            }
            if (playerHP <= 0)
            {
                gameFlag = false;
            }
            else 
            {
                enemy_counter--;
            }
            enemyHP = 15;
        }
        public void Healing()
        {// лечение
            playerHP += 15;
            if (playerHP > 30)
            {
                playerHP = 30;
            }
        }
        public void Buff()
        {//увеличение силы
            player_punch_force = 10;
            buffFlag = true;
        }
        public void SaveState(System.ConsoleKey btn_pressed)//сохра
        {
            if (btn_pressed == ConsoleKey.Escape)
            {
                using (FileStream file = new FileStream(path_for_save, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    { 
                        for (int i = 0; i < map.Length / height; i++)
                        {
                            for (int j = 0; j < map.Length / width; j++)
                            {
                                sw.Write(map[i, j]);
                            }
                            sw.WriteLine();
                        }
                        sw.WriteLine("---");
                        sw.WriteLine(step_counter);
                        sw.WriteLine(enemy_counter);
                        sw.WriteLine(playerHP);
                        sw.WriteLine(buff_counter);
                        sw.WriteLine("---");
                        for (int i = 0; i < enemies.Length; i++)
                        {
                            sw.WriteLine(enemies[i]);
                        }
                        sw.WriteLine("---");
                        for (int i = 0; i < medicine.Length; i++)
                        {
                            sw.WriteLine(medicine[i]);
                        }
                        sw.WriteLine("---");
                        for (int i = 0; i < buffs.Length; i++)
                        {
                            sw.WriteLine(buffs[i]);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Ваша игра успешно сохранена. \n Нажмите любую кнопку, чтобы выйти");
                    Console.ReadKey();
                    gameFlag = false;
                }
            }
        }
        public void LoadState() 
        {
            int count = 20;
            int width_counter = 0;
            using (StreamReader sr = new StreamReader(path_for_save))
            {
                for (int x = 0; x < height; x++)
                {
                    string line = sr.ReadLine();
                    char[] temp = line.ToCharArray();
                    for (int y = 0; y < width; y++)
                    {
                        map[x, y] = temp[y];
                    }
                }
            }
        }
    }
}