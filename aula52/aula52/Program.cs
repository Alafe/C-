using System;

namespace aula52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;

            Console.Write("valor 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("valor 2: ");
            n2 = int.Parse(Console.ReadLine());
            try
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Erro: {0}", e.GetType());
            }
            Console.ReadKey();

        }
    }
}
