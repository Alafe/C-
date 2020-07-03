using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bitwise
            //deslocamento dos bits para a esqueda ou para a direita
            int valor = 10;
            Console.WriteLine(valor);
            //Bitwise para a esquerda vai dobrar o valor
            valor <<= 1; //desloca o bit 1 vez para a esquerda
            Console.WriteLine(valor);
            //Bitwise para a direita vai dividir o valor
            valor >>= 2;//desloca o bit 2 vez para a direita
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
