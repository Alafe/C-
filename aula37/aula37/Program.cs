using System;

namespace aula37
{
    //Herança/ordem de execução dos contrutores
    class Base
    {
        public Base()
        {
            Console.WriteLine("Contrutor da Classe Base");
        }
    }

    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Contrutor da Classe Derivada 1");
        }
    }

    class Derivada2:Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Contrutor da Classe Derivada 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
            Console.ReadKey();
        }
    }
}
