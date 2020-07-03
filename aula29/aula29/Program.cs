using System;

namespace aula29
{
    //contrutor e destrutor
    public class Jogador
    {
        public string nome;
        public int energia;
        public bool vivo;
        

        public Jogador(string n)
        {
            nome = n;
            energia = 100;
            vivo = true;
        }

        ~Jogador()
        {
            Console.WriteLine("Jogador foi destruido");


        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Alafe");
            Jogador j2 = new Jogador("Théo");

            Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
            Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
            Console.ReadKey();

        }
    }
}
