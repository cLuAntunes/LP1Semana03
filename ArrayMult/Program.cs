using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] A = new float[2, 2];
            float[] b = new float[2];

            A = new float[2, 2]
            {
                { float.Parse(args[0]), float.Parse(args[1]) },
                { float.Parse(args[2]), float.Parse(args[3]) }
            };

            b[0] = float.Parse(args[4]);
            b[1] = float.Parse(args[5]);
            
        }
    }
}
