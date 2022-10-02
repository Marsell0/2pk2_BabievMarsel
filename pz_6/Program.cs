namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int pows = 1;
            while (true)
            {
                pows *= 2;
                if (pows < N)
                {
                    Console.WriteLine(pows);
                }
                else 
                {
                    break;
                }
            }
        }
    }
}