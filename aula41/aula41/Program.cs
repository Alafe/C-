using System;

namespace aula41
{
    class Program
    {
        //acessors GET e SET

        class Carro
        {
            private int velMax;

            public int vm
            {
                get
                {
                    return velMax;
                }
                set
                {
                    if (value < 0)
                    {
                        velMax = 0;
                    }
                    else if (value > 300)
                    {
                        velMax = 300;
                    }
                    else
                    {
                        velMax = value;
                    }
                }
            }

            public Carro()
            {
                velMax = 120;
            }


        }
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.vm = 200;
            Console.WriteLine("Velocidade:{0}",c1.vm);
            Console.ReadKey();
        }
    }
}
