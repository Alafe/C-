using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores e operações
            bool res1 = (5 > 7) & (10 > 5);
            bool res2 = (5 > 7) | (10 > 5);
            Console.WriteLine("res1: " + res1);
            Console.WriteLine("res2: " + res2);
            Console.ReadKey();
        }
    }
}
