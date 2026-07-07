using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03_Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1;
            double P2;
            double P3;
            double PF;
            double MP;
            double MF;

            Console.BackgroundColor = ConsoleColor.Blue ;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Digita o valor de P1:");
            Console.SetCursorPosition(21, 0);
            P1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita o valor de P2:");
            Console.SetCursorPosition(21,1);
            P2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita o valor de P3:");
            Console.SetCursorPosition(21, 2);
            P3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita o valor de PF:");
            Console.SetCursorPosition(21, 3);
            PF = double.Parse(Console.ReadLine());
            
            MP = (P1 + P2 + P3) / 3;
            MF = (MP +(PF * 2))/3;

            Console.WriteLine("Média Parcial: " + MP+" Média Final: " + MF);

            if (MF <= 4)
            {al
                Console.WriteLine("Repetiu de ano");
            }

            else
            {
                Console.WriteLine("Passou de ano");
            }
            Console.ReadLine();
            if (MF > 10)
            {
                Console.WriteLine("A vida é feita de escolhas e tu escolheu tirar um nota boa só pra satisfazer suas decisões ruims vai tocar em uma grama e casar :)");
            }
            Console.ReadLine();


        }
    }
}
