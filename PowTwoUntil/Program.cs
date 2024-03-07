using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            PowersOf2UntilN(8);
            PowersOf2UntilN(3);
            PowersOf2Until5();

        }
    }

}
