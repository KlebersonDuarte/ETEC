using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL04_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1º;
            double Nota2º;

            double Média;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Nota 1º: ");
            Console.SetCursorPosition(8, 0);
            Nota1º = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2º: ");
            Console.SetCursorPosition(8, 1);
            Nota2º = double.Parse(Console.ReadLine());

            Média = (Nota1º + Nota2º) / 2;
            Console.WriteLine("Sua média é:" + Média);
            Console.ReadLine(); 







        }
    }
}
