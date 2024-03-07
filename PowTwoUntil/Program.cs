using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
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

        }
    }

}
