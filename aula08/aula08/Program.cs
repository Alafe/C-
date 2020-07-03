using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //lendo valores do teclado
            string nome;
            int idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Nome: {0}\nIdade: {1}", nome, idade);
            Console.ReadKey();
        }
    }
}
