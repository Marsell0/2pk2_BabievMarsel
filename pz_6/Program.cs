namespace pz_6
{
    internal class Program
    {
        /*
         * 
         */
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int result = 1;
            while (true) 
            { 
                result *= 2; 
                if (result < n)
                { 
                    Console.WriteLine(result);
                    ++i;
                }
                else
                {
                    break;
                }
            }
        }
    }
}