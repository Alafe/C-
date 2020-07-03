using System;

namespace aula36
{
    class Veiculo //classe Base
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;


        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
