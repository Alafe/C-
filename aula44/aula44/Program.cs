using System;

namespace aula44
{
    class Program
    {
        //struct
        struct Carro
        {
            public string marca;
            public string modelo;
            public string cor;

            public Carro(string marca, string modelo, string cor)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
            }

            public void info()
            {
                Console.WriteLine("Marca:...{0}", marca);
                Console.WriteLine("Modelo:..{0}", modelo);
                Console.WriteLine("Cor:.....{0}", cor);
            }

        }

        static void Main(string[] args)
        {
            //sem contrutor
            Carro c1;
            c1.marca = "VW";
            c1.modelo = "Golf";
            c1.cor = "Azul";
            c1.info();
            Console.WriteLine();
            
            
            //com contrutor
            Carro c2 = new Carro("Honda","HRV","Prata");
            c2.info();
            Console.ReadKey();
        }
    }
}
