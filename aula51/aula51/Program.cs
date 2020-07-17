﻿using System;

namespace aula51
{
    class Program
    {
        //argumentos de entrada do programa
        static void Main(string[] args)
        {
            int res = 0;
            if(args.Length > 0)
            {
                Console.WriteLine("Qtde de argumentos: {0}", args.Length);
                for (int i = 0; i <= args.Length; i++)
                {
                    res += int.Parse(args[i]);
                }
                Console.WriteLine("Soma: {0}", res);
            }
            else
            {
                Console.WriteLine("Não foi passado argumento");
            }
            Console.ReadKey();
        }
    }
}
