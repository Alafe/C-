using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //typecast
            //converte um tipo em em outro
            int n1 = 10;
            float n2 = n1;//converção implicita
            Console.WriteLine(n2);

            float n3 = 10.5f;
            int n4 = (int)n3;//type cast
            Console.WriteLine(n4);
            Console.ReadKey();
        }
    }
}
