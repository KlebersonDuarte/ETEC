using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX29_PRL_131125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[10];

            for (int i = 0; i < lista.Length; i++) {
            
                Console.Write("Digite um múmero:");
                lista[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            Console.Write("Numeros digitados:");
            for (int j = 0; j < lista.Length; j++) { 
            Console.WriteLine("{0}, ", lista[j]);
            }

            Console.ReadLine();

            Console.WriteLine("\nNova lista:");
            for (int k = 0; k < lista.Length; k++) {

                if (lista[k] % 2 == 0)
                {
                    lista[k] = lista[k] + 5;
                }

                else {
                    lista[k] = lista[k] *5;
                }

                Console.WriteLine("{0}, ", lista[k]);

            }
            Console.ReadLine();
        }
    }
}
