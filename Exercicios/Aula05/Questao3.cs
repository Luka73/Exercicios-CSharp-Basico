using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao3
    {
        static void Main(string[] args)
        {
            String[] arr = new String[3];

            Console.WriteLine("Digite o primeiro nome: ");
            arr[0] = Console.ReadLine();

            Console.WriteLine("Digite o segundo nome: ");
            arr[1] = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nome: ");
            arr[2] = Console.ReadLine();

            Console.WriteLine("Digite o nome a ser consultado: ");
            String nome = Console.ReadLine();

            foreach (String s in arr)
            {
                if (s.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(nome + " pertence a lista de nomes.");
                }
            }

            Console.ReadKey();
        }
    }
}
