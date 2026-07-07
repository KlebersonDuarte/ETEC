using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX32_PRL_261125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Palavra;
            int Tamanho;

            Console.Clear();
            Console.Write("Digite uma palavra:");
            Palavra = Console.ReadLine();

            Tamanho = Palavra.Length;

            Console.Write("Número de caracteres:"+Tamanho);

            Console.ReadLine();
        }
    }
}
