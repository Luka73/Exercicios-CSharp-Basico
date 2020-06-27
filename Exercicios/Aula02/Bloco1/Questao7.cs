using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine()); //100

            Console.WriteLine("Digite o número de votos bracos: ");
            double votosBrancos = double.Parse(Console.ReadLine()); //20

            Console.WriteLine("Digite o número de votos nulos: ");
            double votosNulos = double.Parse(Console.ReadLine()); //10

            Console.WriteLine("Digite o número de votos válidos: ");
            double votosValidos = double.Parse(Console.ReadLine()); //70

            double totalDeVotos = votosBrancos + votosNulos + votosValidos;

            double percentualBrancos = (votosBrancos / totalDeVotos) * 100;
            double percentualNulos = (votosNulos / totalDeVotos) * 100;
            double percentualValidos = (votosValidos / totalDeVotos) * 100;

            Console.WriteLine("Total de eleitores: " + eleitores);
            Console.WriteLine("Votos brancos: " + percentualBrancos + "%");
            Console.WriteLine("Votos nulos: " + percentualNulos + "%");
            Console.WriteLine("Votos válidos: " + percentualValidos + "%");
            Console.ReadKey();
        }
    }
}
