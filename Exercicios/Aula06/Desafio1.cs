using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Desafio1
    {
        static void Main(string[] args)
        {
            int vogais = ContaVogais("LuAna");
            Console.WriteLine("O texto contém " + vogais + " vogais.");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static int ContaVogais(String texto)
        {
            int count = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (EVogal(texto.ElementAt(i)))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool EVogal(char letra)
        {
            char v = Char.ToLower(letra);
            return v == 'a' || v == 'e'
                    || v == 'i' || v == 'o'
                    || v == 'u';
        }
    }
}
