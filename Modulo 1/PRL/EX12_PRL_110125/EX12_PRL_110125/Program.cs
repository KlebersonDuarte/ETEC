using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EX12_PRL_110125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Numero1; 
            double Numero2; 

            double Maior; 

            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            Console.SetCursorPosition(25, 0);
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Console.SetCursorPosition(24, 1);
            Numero2 = double.Parse(Console.ReadLine());

            if (Numero1 > Numero2) 
            {
                Maior = Numero1;
            }
            else
            {
                Maior = Numero2;
            }
            Console.WriteLine("O maior número é:" + Maior);
            Console.ReadLine();


        }
    }
}
