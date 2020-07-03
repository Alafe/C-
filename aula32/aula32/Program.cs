using System;

namespace aula32
{

    // This
    class Calculos
    {
        public int v1;
        public int v2;

        public Calculos(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Somar()
        {
            return v1 + v2;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(10,15);
            Console.WriteLine(c.Somar());

            Console.ReadKey();
        }
    }
}
