using System;

namespace aula10
{
    class Program
    {
        enum DiasSemana
        {
            Domingo,
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        static void Main(string[] args)
        {
            //enumeradores(enum)
            //DiasSemana ds = DiasSemana.Domingo;
            DiasSemana ds = (DiasSemana)6;
            Console.WriteLine(ds);
            Console.ReadKey();
        }
    }
}
