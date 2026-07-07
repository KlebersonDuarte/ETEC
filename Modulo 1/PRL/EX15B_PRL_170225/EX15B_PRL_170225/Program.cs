using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15B_PRL_170225
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

            if (Numero <= 50)
            {
              
            }
            else { 
                if (Numero > 90)
                {

                }
                else
                {
                    Console.WriteLine("Número: " + Numero);
                }
            }
            Console.ReadLine();
        }
    }
}
