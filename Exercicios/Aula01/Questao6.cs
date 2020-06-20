using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula01
{
    public class Questao6
    {
        static void Main(string[] args)
        {
            //Notas de inglês do Gabriel
            double p1 = 6.5;
            double p2 = 7.8;
            double p3 = 8.0;
            double p4 = 7.1;
            double somaDosPesos = 2 + 2 + 3 + 3;

            double mediaPonderada = ((p1 * 2) + (p2 * 2) + (p3 * 3) + (p4 * 3)) / somaDosPesos;
            Console.WriteLine("A média ponderada do Gabriel é: " + mediaPonderada); //7.39
            Console.ReadKey();
        }
    }
}
