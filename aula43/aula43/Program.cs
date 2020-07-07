using System;

namespace aula43
{
    //interfaces
    //interfaces, elas so implementa métodos ou os prototipos dos métodos
    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }

    public interface Combate
    {
        void disparar();
    }

    class Carro:Veiculo,Combate
    {
        public bool ligado;
        private int municao;
        public Carro()
        {
            this.municao = 100;
        }

        public void setMunicao(int qtde)
        {
            this.municao = qtde;
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public void disparar()
        {
            
        }

        public void info()
        {
            
        }

        public void ligar()
        {
            this.ligado = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.ligar();
            Console.ReadKey();
        }
    }
}
