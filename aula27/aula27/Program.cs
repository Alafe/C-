using System;

namespace aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(1, 2, 3, 4, 5);
            Console.ReadKey();
        }

        static void soma(params int[] n)
        {
            int res = 0;

            if (n.Length == 0)
            {
                Console.WriteLine("Não existe valores a serem somados");
            }
            else if (n.Length == 1)
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
            }
            else
            {
                foreach (int v in n)
                {
                    res += v;
                }
                Console.WriteLine("A soma é: {0}", res);
            }

        }
    }
}
