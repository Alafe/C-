using System;

namespace aula48
{
    class Program
    {
        //Recursividade
        //uma função chamando ela mesma
        class Calc
        {
            //5! = 5*4*3*2*1
            public int fat(int n)
            {
                int res;
                if (n <= 1)
                {
                    res = 1;
                }
                else
                {
                    res = n * fat(n - 1);
                }

                return res;
            }


        }

        static void Main(string[] args)
        {
            int res;

            Calc v = new Calc();

            res = v.fat(4);

            Console.WriteLine("Valor: {0}", res);

            Console.ReadKey();

        }
    }
}
