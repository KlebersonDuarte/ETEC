using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX22_PRL_231025
{
    internal class Program
    {
        static long Fatorial (int N)
        {
            if (N <= 1)
            { //Condicional 1
                return 1; // Retorno para código
            }

            else { 
            return N * Fatorial (N - 1); //Retorna para o código
            }
        }
        static void Main(string[] args)
        {
            int numero; // variavel inteira 

            Console.Write("Digite o numero para fatorar:"); // interface 1


            numero = int.Parse(Console.ReadLine()); // entrada 1

            Console.ForegroundColor = ConsoleColor.Cyan; //  cor letra

            for (int i = 0; i <=numero; i++) {
                Console.WriteLine("{0}! = {1} ", i, Fatorial(i)); // Saída -chama função
            }
            Console.ReadLine();


        }
    }
}
    