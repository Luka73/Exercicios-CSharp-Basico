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
            Console.WriteLine("Digite sua idade: "); //15
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você é estudante? [S/N] "); //N
            String estudante = Console.ReadLine();

            // String nome1 = "Luana Fernandes"
            // String nome2 = "Luana Fernandez"
            // nome1 == nome2
            // L == L
            // u == u
            // ASCII 
   
            bool bIdade = idade < 21 || idade > 65; //true
            bool bEstudante = estudante.Equals("s", StringComparison.OrdinalIgnoreCase); //false

            if (bIdade || bEstudante) 
                Console.WriteLine("Paga meia-entrada");
            else
                Console.WriteLine("Paga entrada inteira");
            
            Console.ReadKey();
        }
    }
}
