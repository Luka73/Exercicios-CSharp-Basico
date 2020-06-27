using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02
{
    public class Desafio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano: "); 
            int anoTeste = int.Parse(Console.ReadLine()); 
            
            if(anoTeste % 4 == 0 && anoTeste % 100 != 0 || anoTeste % 400 == 0) 
            { 
                Console.WriteLine(anoTeste + " é um ano Bisexto!"); 
            } 
            else 
            { 
                Console.WriteLine(anoTeste + " não é um ano Bisexto!"); 
            }

            //Um ano bissexto é um ano que é divisível por 4 e não é por 100 ou é
            //divisível por 400.

            //x % 4 == 0 AND y % 100 != 0
            //z % 400 == 0
        }
    }
}
