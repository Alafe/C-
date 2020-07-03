using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do While
            string[] linguagem = { "C#", "Python", "R", "Java", "JavaScript", "PHP", "Ruby", "C", "C++", "HTML" };
            int cont = 0;
            do
            {
                Console.WriteLine("{0}: Curso de {1}", cont + 1, linguagem[cont]);
                cont++;
            } while (cont < 10);
            Console.WriteLine("\nFim do While");
            Console.ReadKey();
        }
    }
}
