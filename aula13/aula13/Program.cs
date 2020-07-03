using System;

namespace aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF-ELSE
            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;
            string resultado = "Reprovado";

            Console.Write("Digita a nota 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digita a nota 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digita a nota 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digita a nota 4: ");
            n4 = int.Parse(Console.ReadLine());
            res = (n1 + n2 + n3 + n4) / 4;
            if (res < 3)
            {
                resultado = "Reprovado";
            }
            else if(res < 5)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Aprovado";
            }

            Console.Clear();
            Console.WriteLine("média: {0}\nResultado: {1}", res, resultado);
            Console.ReadKey();

        }
    }
}
