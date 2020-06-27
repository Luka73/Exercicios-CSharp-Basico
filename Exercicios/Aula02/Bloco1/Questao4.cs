using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade ");
            int idade = int.Parse(Console.ReadLine());

            //DateTime now = DateTime.Now;
            //int anoDeNascimento = now.Year - idade;

            int anoDeNascimento = 2020 - idade;

            Console.WriteLine(nome + " nasceu em " + anoDeNascimento);
            Console.ReadKey();
        }
    }
}
