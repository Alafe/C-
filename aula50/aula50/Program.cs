using System;

namespace aula50
{
    class Program
    {
        //Delegates
        delegate int Op(int n1, int n2);

        class Mat
        {
            public static int soma(int n1, int n2)
            {
                return n1+n2;
            }

            public static int mult(int n1, int n2)
            {
                return n1 * n2;
            }

        }

        static void Main(string[] args)
        {
            int res;
            Op d = new Op(Mat.soma);
            res = d(10,50);
            Console.WriteLine("Soma: {0}", res);

            d = new Op(Mat.mult);
            res = d(10, 50);
            Console.WriteLine("Mult: {0}", res);

            Console.ReadKey();
        }
    }
}
