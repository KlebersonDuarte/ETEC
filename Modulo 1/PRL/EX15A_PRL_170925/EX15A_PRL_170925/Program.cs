using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15A_PRL_170925
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

            if (Numero >50)
            {
                if (Numero <=90)
                {
                    Console.WriteLine("Nunmero: " + Numero);
                    
                }
            }
            Console.ReadLine();

        }
    }
}
