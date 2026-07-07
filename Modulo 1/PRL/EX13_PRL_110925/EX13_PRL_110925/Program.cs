using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_PRL_110925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SB;
            double SL;
            double IR;
            double Sbase;
            double G;

            Console.WriteLine("Digite seu saláro base:");
            Console.SetCursorPosition(23, 0);
            Sbase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Gratificação: ");
            Console.SetCursorPosition(24, 1);
            G = double.Parse(Console.ReadLine());

            SB = Sbase + G;
            if (SB > 3000)
            {
                IR = SB * 0.15;
            }

            else
            {
                IR = SB - 0.11;
            }

            SL = SB -IR;

            Console.WriteLine("Seu salário bruto é:" + SB);
            Console.WriteLine("Seu imposto de renda é:" + IR);
            Console.WriteLine("Seu salário líquido é:" + SL);
            Console.ReadLine();


        }
    }
}
