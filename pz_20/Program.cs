namespace pz_20
{
    internal class Program
    {
        string gh = "werwer";
        static string ReverseReg(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {   
                    result += Char.ToLower(text[i]);
                }
                else if (Char.IsLower(text[i]))
                {
                    result += Char.ToUpper(text[i]);
                }
                else
                {
                    result += text[i];
                }
            }
            try
            {
                Console.WriteLine(text[10]);
            }catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Исключение обработано");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseReg("Hel! lo"));
        }
    }
}