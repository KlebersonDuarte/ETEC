using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_PRL_100925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um numerp: ");
                double numero = double.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    Console.WriteLine("Seu numero é maior que 100");
                }
                else
                {
                    Console.Write("Seu numero não é maior que 100");
                }
            }

            catch
            {
                Console.WriteLine("Numero inválido");
            }
        }
    }
}
