using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_PRL_170925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            string Status = " ";

            Console.Clear();
            Console.WriteLine("Digite um número: ");
            Console.SetCursorPosition(17, 0);
            Numero = int.Parse(Console.ReadLine());

            if (Numero !=0)
            {
                if (Numero > 0)
                {
                    Status = "Positivo";
                }
                else 
                {

                    Status = " Negativo";

                }

            }
            else
            {
                Status = "Neutro";

            }
            Console.WriteLine("Resultado: " + Status);
            Console.ReadLine();



        }
    }
}
