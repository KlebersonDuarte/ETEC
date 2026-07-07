using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_PRL_210825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TF;
            double TC;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a temperatura em Cº: ");
            Console.SetCursorPosition(28, 0);
            TC = Double.Parse(Console.ReadLine());
            TF = 1.8 * TC + 32;
            Console.WriteLine("Sua temperatura em Fº:" + TF);
            Console.ReadLine();
        }
    }
}
