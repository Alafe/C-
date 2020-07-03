using System;

namespace aula35
{
    class Veiculo //Classe Veiculo
    {
        private int rodas;
        public int velMax;
        public bool ligado;

        public Veiculo(int rodas)
        {

        }

        public int getRodas()
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            if (rodas < 0)
            {
                rodas = 0;
            }
            else if (rodas > 40)
            {
                rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }

        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public string getLigado()
        {
            return (ligado ? "Sim" : "Não");
        }
    }

    class Carro : Veiculo //classe Base
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor):base(4)
        {
            desligar();
            
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate:Carro
    {
        public int municao;

        public CarroCombate(int munincao,string nome, string cor, int rodas) : base(nome, cor)
        {
            municao = 100;
            setRodas(6);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão", "Vermelho");
            CarroCombate cc1 = new CarroCombate(100, "Carro Combate", "vermelho", 6);
            c1.ligar();

            Console.WriteLine("Cor:.......{0}", cc1.cor);
            Console.WriteLine("Nome:......{0}", cc1.nome);
            Console.WriteLine("Rodas:.....{0}", cc1.getRodas());
            Console.WriteLine("Vel.Maxima:{0}", cc1.velMax);
            Console.WriteLine("Ligado:....{0}", cc1.getLigado());
            Console.WriteLine("Munição:...{0}", cc1.municao);

            Console.ReadKey();
        }
    }
}
