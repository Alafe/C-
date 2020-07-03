using System;

namespace aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            string[] linguagem = {"C#", "Python", "R", "Java", "JavaScript", "PHP", "Ruby", "C", "C++", "HTML"};
            int cont = 0;
            while (cont < 10)
            {
                Console.WriteLine("{0}: Curso de {1}", cont + 1, linguagem[cont]);
                cont++;
            }
            Console.WriteLine("\nFim do While");
            Console.ReadKey();

        }
    }
}
