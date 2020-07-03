using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    class Program
    {
        static void Main(string[] args)
        {

            //For
            int[] n = new int[10];
            for (int i = 0,x = 5; i<10; i++, x+=5)
            {
                n[i] = x;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número {0}: {1}", (i+1), n[i]);
            }
            Console.ReadKey();
        }
    }
}
