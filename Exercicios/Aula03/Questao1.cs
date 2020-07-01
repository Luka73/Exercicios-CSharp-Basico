using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula03
{
    public class Questao1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: ( + - * / ) ");
            string operacao = Console.ReadLine();

            switch(operacao)
            {
                case "+":
                    Console.WriteLine("Soma: " + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine("Subtração: " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine("Multiplicação: " + (n1 * n2));
                    break;
                case "/":
                    if(n2 != 0)
                        Console.WriteLine("Divisão: " + (n1 / n2));
                    else
                        Console.WriteLine("Não é possível efetuar divisão por zero.");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
