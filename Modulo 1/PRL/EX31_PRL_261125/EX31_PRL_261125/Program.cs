using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX31_PRL_261125
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Palavra;
            string Maiusculo, Minusculo;

            Console.Clear();

            Console.Write("Digite uma palavra:");
            Palavra = Console.ReadLine();

            Maiusculo = Palavra.ToUpper();
            Minusculo = Maiusculo.ToLower();

            Console.WriteLine("Maiusculo:" + Maiusculo);
            Console.WriteLine("Minusculo:" + Minusculo);

            Console.ReadLine();
        }
    }
}
