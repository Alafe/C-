using System;
//membros protect
namespace aula36
{
    class Veiculo //classe Base
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;


        public Veiculo(int velMax) //contrutor
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getLigado()
        {
            return ligado;
        }

        public int getVelMax()
        {
            return velMax;
        }
    }

    class Carro:Veiculo{ //derivada de veiculo
        public string nome;

        public Carro(string nome, int vm):base(vm)
        {
            this.nome = nome;
            ligado = true;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Bonitao", 120);

            Console.WriteLine("nome:.........{0}",carro.nome);
            Console.WriteLine("vel.Maxima:...{0}", carro.getVelMax());
            Console.WriteLine("Ligado:.......{0}",carro.getLigado());

            Console.ReadKey();
        }
    }
}
