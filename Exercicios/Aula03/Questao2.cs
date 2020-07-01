using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula03
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um combustível: ");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Quantos litros você deseja? ");
            double litros = double.Parse(Console.ReadLine());
            double desconto = 0;
            double preco = 0;

            switch(combustivel.ToUpper())
            {
                case "A":
                    desconto = (litros > 20) ? 0.05 : 0.03;
                    preco = 2.90 * litros;
                    break;
                case "G":
                    desconto = (litros > 20) ? 0.06 : 0.04;
                    preco = 3.30 * litros;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            double precoFinal = preco * (1 - desconto);
            Console.WriteLine("Valor a pagar: " + precoFinal);
            Console.ReadKey();
        }
    }
}
