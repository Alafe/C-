using System;

namespace aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goto
            string voltar;
            int valor = 0;
            inicio:
            Console.Clear();
            Console.Write("Digite um numero: ");
            valor += int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Total: {0}", valor);
            Console.Write("Deseja inserir um novo valor[N/S]: ");
            voltar = Console.ReadLine();
            if (voltar.ToUpper() == "S")
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("fim do programa");
                Console.ReadKey();
            }

        }
    }
}
