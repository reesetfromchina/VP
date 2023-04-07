namespace firstConsoleAppREAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niza = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int max = findMax(niza);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        private static int findMax(int[] niza)
        {
            int max = niza[0];
            for(int i =1; i< niza.Length; i++)
            {
                if (niza[i] > max)
                {
                    max = niza[i];
                }
            }
            return max;
        }
    }
}