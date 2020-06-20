using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula01
{
    public class Questao7
    {
        static void Main(string[] args)
        {
            double raio = 6.5;
            double perimetro = 2 * raio * Math.PI;
            double area = raio * raio * Math.PI;

            Console.WriteLine("O Perímetro é: " + perimetro); //40.8407...
            Console.WriteLine("O Área é: " + area); //132.7322...
            Console.ReadKey();
        }
    }
}
