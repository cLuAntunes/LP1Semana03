using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Insira um caráter: ");
            char replace = Console.ReadKey().KeyChar;

            foreach (char s in str)
            {
                if (s == replace)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(s);
                }
            }
        }
    }
}
