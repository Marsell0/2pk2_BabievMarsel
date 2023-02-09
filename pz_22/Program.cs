namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice first = new Invoice(1, "до 21.02.2022", "Сыр", 10, 135);
            Invoice second = new Invoice(2, "до 21.06.2023", "Колбаса", 23, 240, 20);
            Invoice third = new Invoice(3, "до 1.01.2022", "Хлеб", 10, 32, 5);
            Invoice fourth = new Invoice(4, "до 24.12.2001", "Масло", 100, 50, 10);
            first.PrintInfo();
            Console.WriteLine(first.GetFullPrice());
            Console.WriteLine();
            second.PrintInfo();
            Console.WriteLine(second.GetFullPrice());
            Console.WriteLine();
            third.PrintInfo();
            Console.WriteLine(third.GetFullPrice());
            Console.WriteLine();
            fourth.PrintInfo();
            Console.WriteLine(fourth.GetFullPrice());
        }
    }
}