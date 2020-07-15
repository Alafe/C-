using System;

namespace aula47
{
    class Program
    {
        //sobrecarga de métodos
        class Calc
        {
            public int soma(params int[] valor)
            {
                int s = 0;
                foreach (int v in valor)
                {
                    s += v;
                }
                return s;
            }
            
            public double soma(params double[] valor)
            {
                double s = 0;
                foreach (double v in valor)
                {
                    s += v;
                }
                return s;
            }

        }

        static void Main(string[] args)
        {
            int res1;
            double res2;
            Calc calc = new Calc();

            res1 = calc.soma(10,5);
            res2 = calc.soma(10.8, 5.7, 15.3, 20.1);

            Console.WriteLine("1ª resposta: {0}", res1);
            Console.WriteLine("2ª resposta: {0}", res2);

            Console.ReadKey();

        }
    }
}
