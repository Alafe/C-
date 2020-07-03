using System;

namespace aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch case
            Console.Write("Digite uma linguagem: ");
            string linguagem = Console.ReadLine();
            switch (linguagem.ToUpper())
            {
                case "JAVA":
                case "C#":
                case "PYTHON":
                    Console.WriteLine("Linguagem de Programação");
                    break;
                case "HTML":
                case "XML":
                    Console.WriteLine("Linguagem de Marcação");
                    break;
                default:
                    Console.WriteLine("Linguagem não conheçida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
