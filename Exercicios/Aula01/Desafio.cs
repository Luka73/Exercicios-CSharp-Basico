using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula01
{
    public class Desafio
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double c = -6;

            double delta = (Math.Pow(b, 2)) - 4 * a * c;
            Console.WriteLine("Delta: " + delta); //64

            double div = 2 * a;
            double x1 = (-b + Math.Sqrt(delta)) / div;
            double x2 = (-b - Math.Sqrt(delta)) / div;

            Console.WriteLine("X1: " + x1); //1
            Console.WriteLine("X2: " + x2); //-3
            Console.ReadKey();
        }
    }
}
