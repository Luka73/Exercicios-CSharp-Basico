using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] idades = { 23, 35, 83, 10, 56 };
            double[] salarios = new double[5];
            salarios[0] = 2000;
            salarios[1] = 2500;
            salarios[2] = 1400;
            salarios[3] = 3500;
            salarios[4] = 1800;

            //array 
            //vetor (array unidimensional)
            int soma = 0;
            for(int i = 0; i < idades.Length; i++)
            {
                soma = soma + idades[i];
                Console.WriteLine(idades[i]);
            }
            
            Console.WriteLine("Soma das idades: " + soma);

            Console.ReadKey();
        }
    }
}
