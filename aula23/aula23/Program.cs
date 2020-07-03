using System;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 33, 44, 55 }, { 66, 77, 88, 99, 00 } };

            Random random = new Random();
            for (int i = 0; i <vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50);
            }

            Console.WriteLine("Elementos do vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }

            //public static int BinarySearch(array, vetor);
            Console.WriteLine("BinarySearch");
            int procurado = 23;
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("Vetor {0} está na posição {1}", procurado, pos);
            Console.WriteLine("---------------------------------------------");

            //public static void Copy(Ar_origem,Ar_destino,qtds_elementos);

            //public void CopyTo(Ar_destino, a_partir_desta_pos);

            Console.ReadKey();
        }
    }
}
