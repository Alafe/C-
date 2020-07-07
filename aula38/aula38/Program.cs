using System;

namespace aula38
{
    //métodos virtuais
    class Base
    {
        public Base()
        {
            Console.WriteLine("Contrutor da Classe Base");
        }

        virtual public void info()
        {
            Console.WriteLine("Base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Contrutor da Classe Derivada 1");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Contrutor da Classe Derivada 2");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Base Ref;
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();

            Ref = derivada2;
            Ref.info();
            Console.ReadKey();
        }
    }
}
