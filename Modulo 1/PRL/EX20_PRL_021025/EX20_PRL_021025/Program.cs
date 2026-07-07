using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EX20_PRL_021025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            try
            {

                int numero;

                Console.Clear();

                Console.Write("Digite um número:");
                numero = int.Parse(Console.ReadLine());

                int meio = numero / 3;
                int comeco = meio - 1;
                int fim = meio + 1;
                //double resultado = comeco+meio+fim;


                if (comeco+meio+fim== numero)
                {
                    Console.Write("Os 3 números consecutivos somados juntos que irão dar o número escolhido é:" +comeco+","+meio+","+fim);
                }

                else
                {
                    Console.Write("Não exite soma de números consecutivos para este número digitado");
                }
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.Write("Digite um número válido");
                Console.ReadLine();
            }
            }
        }
    }
}
