using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco2
{
    public class Questao4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você é estudante? [S/N] "); 
            String estudante = Console.ReadLine();
   
            bool bIdade = idade < 21 || idade > 65;
            bool bEstudante = estudante.Equals("s", StringComparison.OrdinalIgnoreCase); //false

            if (bIdade || bEstudante) 
                Console.WriteLine("Paga meia-entrada");
            else
                Console.WriteLine("Paga entrada inteira");
            
            Console.ReadKey();
        }
    }
}
