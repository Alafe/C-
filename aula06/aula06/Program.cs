using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //formatando a saida no console
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto........:{0,15}", produto);
            Console.WriteLine("Val.compra.....:{0,15:c}",valorCompra);
            Console.WriteLine("lucro..........:{0,15:p}",lucro);
            Console.WriteLine("Val.venda......:{0,15:c}",valorVenda);
            Console.ReadKey();
        }
    }
}
