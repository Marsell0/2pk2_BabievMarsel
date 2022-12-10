namespace pz_18
{
    internal class Program
    {
        enum Marks { Плохо = 1, неудовлетворительно, удовлетворительно, хорошо, отлично }
        enum Seasons {summer, autumn, winter, spring }

        static void firstTask() 
        {
            int mark = Convert.ToInt32(Console.ReadLine());
            switch (mark)
            {
                case 1:
                    Console.WriteLine(Marks.Плохо);
                    break;
                case 2:
                    Console.WriteLine(Marks.неудовлетворительно);
                    break;
                case 3:
                    Console.WriteLine(Marks.удовлетворительно);
                    break;
                case 4:
                    Console.WriteLine(Marks.хорошо);
                    break;
                case 5:
                    Console.WriteLine(Marks.отлично);
                    break;
            }
        }

        static void secondTask()
        {
            string season = Console.ReadLine();
            switch (season)
            {
                case "summer":
                    Console.WriteLine("5.08 Международный день пива");
                    break;
                case "autumn":
                    Console.WriteLine("09.09 Мой День Рождения");
                    break;
                case "winter":
                    Console.WriteLine("31.12-01.01 Новый год");
                    break;
                case "spring":
                    Console.WriteLine("18.03 День воссоединения Крыма с Россией");
                    break;
            }
        }

        static void Main(string[] args)
        {
            firstTask();
            secondTask();
        }
    }
}