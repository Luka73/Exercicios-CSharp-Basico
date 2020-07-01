using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula03
{
    public class Desafio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu dia de nascimento: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu mês de nascimento: ");
            int mes = int.Parse(Console.ReadLine());
            string signo = "";

            switch(mes)
            {
                case 1:
                    signo = (dia <= 20) ? "Capricórnio" : "Áquario";
                    break;
                case 2:
                    signo = (dia <= 19) ? "Aquário" : "Peixes";
                    break;
                case 3:
                    signo = (dia <= 20) ? "Peixes" : "Áries";
                    break;
                case 4:
                    signo = (dia <= 20) ? "Áries" : "Touro";
                    break;
                case 5:
                    signo = (dia <= 20) ? "Touro" : "Gêmeos";
                    break;
                case 6:
                    signo = (dia <= 20) ? "Gêmeos" : "Câncer";
                    break;
                case 7:
                    signo = (dia <= 21) ? "Câncer" : "Leão";
                    break;
                case 8:
                    signo = (dia <= 22) ? "Leão" : "Virgem";
                    break;
                case 9:
                    signo = (dia <= 22) ? "Virgem" : "Libra";
                    break;
                case 10:
                    signo = (dia <= 22) ? "Libra" : "Escorpião";
                    break;
                case 11:
                    signo = (dia <= 21) ? "Escorpião" : "Sagitário";
                    break;
                case 12:
                    signo = (dia <= 21) ? "Sagitário" : "Capricórnio";
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            Console.WriteLine("Seu signo é: " + signo);

            Console.ReadKey();
        }
    }
}
