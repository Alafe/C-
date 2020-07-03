using System;

namespace aula04
{
    class Program
    {
        static int x = 1;

        static void Main(string[] args)
        {
            int y = 1;
            Console.WriteLine(x+y);
            somar(10);
            Console.ReadKey();
        }
        static void somar(int valor)
        {
            //Console.WriteLine(y);
            //y não tem visibilidade neste funçao pois é uma variavel LOCAL
            Console.WriteLine(valor + x); //x tem visibilidade pois é uma variavel GLOBAL
        }
    }
}
