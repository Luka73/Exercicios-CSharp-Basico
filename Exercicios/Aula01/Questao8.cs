using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula01
{
    public class Questao8
    {
        static void Main(string[] args)
        {
            double distanciaEmMilhas = 15 / 1.6;
            double tempoEmMinutos = 50 + (30 / 60);
            double tempoEmHoras = tempoEmMinutos / 60;

            double velocidadeMediaEmMilhas = distanciaEmMilhas / tempoEmHoras;

            Console.WriteLine("A velocidade média por hora em milhas é: " + velocidadeMediaEmMilhas); //11.25
            Console.ReadKey();
        }
    }
}
