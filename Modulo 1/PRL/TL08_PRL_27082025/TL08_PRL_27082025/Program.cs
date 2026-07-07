using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL08_PRL_27082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HT;
            double SB;
            double SL;
            double IMP;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Digite horas trabalhadas: ");
            Console.SetCursorPosition(28, 0);
            HT = int.Parse(Console.ReadLine());

            SB = HT * 10.37 ;
            IMP = SB*0.11 ;
            SL = SB-IMP;

            Console.WriteLine("Salário bruto igual a: " + SB);
            Console.WriteLine("Imposto igual a: " + IMP);
            Console.WriteLine("Salário líquido igual a: " + SL);
       

            Console.ReadLine();




        }
    }
}
