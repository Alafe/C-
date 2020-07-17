using System;

namespace aula54
{
    class Program
    {
        //namespaces
        static void Main(string[] args)
        {
            float area = 0;

            try
            {
                area = Calc1.Area.Quad(10f, 0f);
                Console.WriteLine("Area do quadrado: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("fim do processo");
            }
            Console.ReadKey();
        }
    }
}


namespace Calc1
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}

namespace Calc2
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}