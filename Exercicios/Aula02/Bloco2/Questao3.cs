using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco2
{
    public class Questao3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            DateTime localDate = DateTime.Now;
            int day = localDate.Day;
            int month = localDate.Month;
            int year = localDate.Year;

            //Console.WriteLine(day);
            //Console.WriteLine(month);
            //Console.WriteLine(year);

            int idade = year - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Pode votar");
            }
            else
            {
                Console.WriteLine("Não pode votar");
            }
            Console.ReadKey();
        }
    }
}
