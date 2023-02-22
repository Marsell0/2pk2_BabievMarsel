namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice();
            Invoice invoice2 = (Invoice)invoice1.Clone();
            invoice2.Product = "сыр";
            invoice1.PrintInfo();
            Console.WriteLine();
            invoice2.PrintInfo();

            LandingInvoice landInv = new LandingInvoice("Ivanov Ivan Ivanovich", "с999сс");
            LandingInvoice landInv2 = (LandingInvoice)landInv.Clone();
            landInv2.CourierFIO = "Petrov Petr Petrovich";
            landInv.PrintInfo();
            Console.WriteLine();
            landInv2.PrintInfo();
        }
    }
}