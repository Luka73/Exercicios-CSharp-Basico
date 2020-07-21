using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CelsiusParaKelvin(30));
            Console.ReadKey();
        }

        public static double CelsiusParaKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}
