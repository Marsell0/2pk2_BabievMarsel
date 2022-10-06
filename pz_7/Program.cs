namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[12];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-13, 13);
                Console.Write(arr[i] + " ");
            }
        }
    }
}