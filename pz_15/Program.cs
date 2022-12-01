namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 8];

            string path = @"D:\some_text\pz_15.txt";
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            A[i, j] = i * j;
                            sw.Write(A[i, j] + " ");
                        }
                        sw.WriteLine();
                    }
                }
            }
        }
    }
}