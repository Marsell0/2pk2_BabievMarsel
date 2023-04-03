namespace pz_27
{
    internal class Program
    {
        struct AEROFLOT
        {
            public string NAZN;
            public int NUMR;
            public string TIP;
        }
        static void Main(string[] args)
        {
            const int amount_of_planes = 7;
            AEROFLOT[] AIRPORT = new AEROFLOT[amount_of_planes]; 
            for (int i = 0; i < amount_of_planes; i++)
            {
                AEROFLOT plane = new AEROFLOT();
                Console.WriteLine("Введите пункт назначения рейса: ");
                plane.NAZN = Console.ReadLine();
                Console.WriteLine("Введите номер самолёта: ");
                plane.NUMR = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите тип самолёта: ");
                plane.TIP = Console.ReadLine();
            }
        }
    }
}