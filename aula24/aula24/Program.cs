using System;

namespace aula24
{
    class Program
    {
        static void Main(string[] args)
        {   //métodos
            Soma(5,7);
            Console.ReadKey();
        }

        static void Soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
        }
    }
}
