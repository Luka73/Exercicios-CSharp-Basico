using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potencia(2,10));
            Console.ReadKey();
        }

        public static int Potencia(int b, int exp)
        {
            int pow = 1;
            for (int i = 1; i <= exp; i++)
            {
                pow *= b;
            }
            return pow;
        }
    }
}
