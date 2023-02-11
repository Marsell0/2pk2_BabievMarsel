namespace pz_23
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
            Console.WriteLine();

            LandingInvoice third = new LandingInvoice("Ivanov Ivan Ivanovich", "a123bv");
            third.PrintInfo();
            Console.WriteLine();
            LandingInvoice fourth = new LandingInvoice(new DateTime(2023, 11, 21), "колбаса", 100, 325, 0.2, "Petrov Petr Petrovich", "q089we");
            fourth.PrintInfo();
        }
    }
}