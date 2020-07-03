using System;

namespace aula30
{
    //sobrecarga de contrutor
    public class Jogador
    {
        public string nome;
        public int energia;
        public bool vivo;

        public Jogador()
        {
            nome = "Anonimo";
            energia = 100;
            vivo = true;
        }

        public Jogador(string n, int e, bool v)
        {
            nome = n;
            energia = e;
            vivo = v;
        }

        public void info()
        {
            Console.WriteLine("Nome do Jogador: {0}", nome);
            Console.WriteLine("Energia de {0}: {1}", nome, energia);
            Console.WriteLine("Estado de {0}: {1}\n", nome, vivo? "Vivo":"Morto");
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
            Jogador j1 = new Jogador("Alafe", 100, true);
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador("Rodrigo", 0, false);

            j1.info();
            j2.info();
            j3.info();

            Console.ReadKey();

        }
    }
}
