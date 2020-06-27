using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário atual: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de reajuste: ");
            double percentual = double.Parse(Console.ReadLine());

            double novoSalario = salarioAtual * (1 + percentual / 100);

            Console.WriteLine("O novo salário é R$" + novoSalario);
            Console.ReadKey();
        }
    }
}
