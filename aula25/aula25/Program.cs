using System;

namespace aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            //passagem por referência(ref)
            int num = 10;
            dobrar(ref num);
            Console.WriteLine(num);
            Console.ReadKey();

        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
