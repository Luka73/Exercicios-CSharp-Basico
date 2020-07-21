using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:00.00}", AreaDoCirculo(5.48));
            Console.ReadKey();
        }

        public static double AreaDoCirculo(double raio)
        {
            return Math.PI * raio * raio;
        }
    }
}
