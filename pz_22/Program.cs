namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice first = new Invoice(new DateTime(2025, 5, 15), "Сыр", 10, 135, 0.2);
            first.PrintInfo();
            Console.WriteLine(first.GetFullPrice());
            Console.WriteLine();
            Invoice second = new Invoice();
            second.PrintInfo();
            Console.WriteLine(second.GetFullPrice());
        }
    }
}