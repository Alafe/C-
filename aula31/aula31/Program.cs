using System;

namespace aula31
{
    //classes static
    static public class Jogador
    {
        static public string nome;
        static public int energia;
        static public bool vivo;

        static public void Iniciar()
        {
            nome = "Anonimo";
            energia = 100;
            vivo = true;
        }

        static public void Iniciar(string n, int e)
        {
            nome = n;
            energia = e;
            if (energia > 0)
            {
                vivo = true;
            }
            else
            {
                vivo = false;
            }
        }

        static public void info()
        {
            Console.WriteLine("Nome do Jogador: {0}", nome);
            Console.WriteLine("Energia de {0}: {1}", nome, energia);
            Console.WriteLine("Estado de {0}: {1}\n", nome, vivo ? "Vivo" : "Morto");
        }
    }

    class Inimigo
    {
        static public bool alerta;
        public string nome;

        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
        }

        public void info()
        {
            Console.WriteLine("nome do inimigo: {0}", nome);
            Console.WriteLine("em alerta: {0}", alerta ? "Sim" : "Não");
            Console.WriteLine("-------------------------------");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Jogador.Iniciar("Alafe", 100);
            Jogador.info();

            Inimigo i1 = new Inimigo("Doido");
            Inimigo i2 = new Inimigo("Maluco");
            Inimigo i3 = new Inimigo("Pirado");

            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();

            Console.ReadKey();

        }
    }
}
