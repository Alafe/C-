using System;

namespace aula49
{
    class Program
    {
        //Métodos e Variaveis static
        class Mat
        {
            public static double pi = 3.14;

            public static int dobro(int n)
            {
                return n * 2;
            }

        }

        static void Main(string[] args)
        {
            double vpi = Mat.pi;
            int num = 10;

            Console.WriteLine("Pi: " + vpi);
            Console.WriteLine("Num dobrado é " + Mat.dobro(num));
            Console.ReadKey();
        }
    }
}
