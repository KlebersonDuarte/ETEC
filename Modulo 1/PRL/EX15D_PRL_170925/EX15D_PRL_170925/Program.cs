using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15D_PRL_170925
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numero;

            Console.Clear();
            Console.WriteLine("Digite um número: ");
            Console.SetCursorPosition(17, 0);
            Numero = int.Parse(Console.ReadLine());

            if (Numero <= 50 || Numero > 90)
            { 
            }

            else
            {
                Console.WriteLine("Número: " + Numero);
            }

            Console.ReadLine();
        }
    }
}