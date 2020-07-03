using System;

namespace aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foreach
            string[] linguagem = { "C#", "Python", "R", "Java", "JavaScript", "PHP", "Ruby", "C", "C++", "HTML" };
            foreach (string p in linguagem)
            {
                Console.WriteLine("Curso de " + p);
            }
            
            Console.WriteLine("\nFim do Foreach");
            Console.ReadKey();
        }
    }
}
