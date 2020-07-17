using System;

namespace aula53
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


    class Program
    {
        //try catch e finaly
        static void Main(string[] args)
        {
            float area = 0;
            
            try
            {
                area = Area.Quad(10f,0f);
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
