using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao7
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PadLeft(5, '0', "1")); //"00001"
            Console.WriteLine(PadLeft(5, '0', "123")); //"00123"
            Console.WriteLine(PadLeft(5, '0', "12345")); //"12345"
            Console.WriteLine(PadRight(5, '0', "1")); //"10000"
            Console.WriteLine(PadRight(5, '0', "123")); //"12300"
            Console.WriteLine(PadRight(5, '0', "12345")); //"12345"
            Console.WriteLine(Padding(5, '0', "1", true)); //"10000"
            Console.WriteLine(Padding(5, '0', "1", false)); //"00001"
            Console.ReadKey();
        }

        public static String PadLeft(int n, char element, String value)
        {
            String pad = "";
            int fim = Math.Max(n, value.Length) - Math.Min(n, value.Length);
            for (int i = 1; i <= fim; i++)
            {
                pad += element;
            }

            return pad + value;
        }

        public static String PadRight(int n, char element, String value)
        {
            String pad = "";
            int fim = Math.Max(n, value.Length) - Math.Min(n, value.Length);
            for (int i = 1; i <= fim; i++)
            {
                pad += element;
            }

            return value + pad;
        }

        public static String Padding(int n, char element, String value, bool direita)
        {
            String pad = "";
            int fim = Math.Max(n, value.Length) - Math.Min(n, value.Length);
            for (int i = 1; i <= fim; i++)
            {
                pad += element;
            }

            return (direita) ? value + pad : pad + value;
        }
    }
}
