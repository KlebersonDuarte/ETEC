using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_PRL_210825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor1;
            double Valor2;
            double Soma;
            double Produto;
            double Quadrados;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite seu primeiro valor:");
            Console.SetCursorPosition(26, 0);
            Valor1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu segundo valor:");
            Console.SetCursorPosition(25, 1);
            Valor2 = Double.Parse(Console.ReadLine());

            Soma = (Valor1 + Valor2) * 0.2;
            Produto = (Valor1 * Valor2) * 0.3;
            Quadrados = (Math.Pow(Valor1, 2) + Math.Pow(Valor2, 2)) * 0.4;
            Console.WriteLine("20% de sua soma: " + Soma);
            Console.WriteLine("30% de seu produto: " + Produto);
            Console.WriteLine("40% de seus quadrados: " + Quadrados);
            Console.ReadLine();
        }
    }
}
