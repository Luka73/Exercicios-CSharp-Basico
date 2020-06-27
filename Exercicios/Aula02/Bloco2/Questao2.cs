using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco2
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de maçãs: ");
            int macas = int.Parse(Console.ReadLine());
            double preco = 0;

            if (macas >= 12)
            {
                preco = 1.00;
            }
            else
            {
                preco = 1.30;
            }

            double valorFinal = preco * macas;
            Console.WriteLine("O valor a pagar é R$" + valorFinal);
            Console.ReadKey();
        }
    }
}
