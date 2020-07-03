using System;

namespace aula28
{

    public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50;
            Console.WriteLine("energia do jogador 1: {0}", j1.energia);
            Console.WriteLine("energia do jogador 2: {0}", j2.energia);
            Console.ReadKey();

        }
    }
}
