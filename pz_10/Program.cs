namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ident = Console.ReadLine().ToLower();
            int flag = 1;
            if ('a' <= ident[0] && ident[0] <='z')
            {

                foreach (char i in ident)
                {
                    if ('a' <= i && i <= 'z' || i == '_' || '0' <= i && i <= '9')
                    {
                        flag = 0;
                    }
                    else
                    {
                        flag = 1;
                    }
                    
                }
            }
            if (flag == 1) 
            {
                Console.WriteLine("Это не идентификатор");
            }
            else
            {
                Console.WriteLine("Это идентификатор");
            }
        }
    }
}