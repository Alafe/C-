using System;

namespace aula45
{
    class Program
    {
        //Array de estruturas
        struct Carro
        {
            public string modelo;
            public string cor;

            public void info()
            {
                Console.WriteLine("Modelo:..{0}", this.modelo);
                Console.WriteLine("Cor:.....{0}", this.cor);
                Console.WriteLine("-----------------------");
            }

        }

        static void Main(string[] args)
        {
            //sem contrutor
            Carro[] carro = new Carro[4];

            carro[0].modelo = "HRV";
            carro[0].cor = "Prata";

            carro[1].modelo = "Golf";
            carro[1].cor = "Azul";

            carro[2].modelo = "Jetta";
            carro[2].cor = "Branco";

            carro[3].modelo = "Argo";
            carro[3].cor = "Preto";

            for (int i = 0; i < carro.Length; i++)
            {
                carro[i].info();
            }

            Console.ReadKey();
        }
    }
}
