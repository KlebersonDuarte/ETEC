using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX28_PRL_121125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MatrizVenda = new int[3, 4];
            int NumVend;
            int NumProd;
            int Op;

            int Soma = 0;

            MatrizVenda[0, 0] = 22;
            MatrizVenda[0, 1] = 15;
            MatrizVenda[0, 2] = 6;
            MatrizVenda[0, 3] = 7;

            MatrizVenda[1, 0] = 12;
            MatrizVenda[1, 1] = 14;
            MatrizVenda[1, 2] = 8;
            MatrizVenda[1, 3] = 23;

            MatrizVenda[2, 0] = 5;
            MatrizVenda[2, 1] =9;
            MatrizVenda[2,2] = 16;
            MatrizVenda[2, 3] = 18;

            Console.Clear();
            Console.WriteLine("\nEscolha a opção desejada:");
            Console.WriteLine("1 - Total por vendedor");
            Console.WriteLine("2 - Total por produto");
            Console.WriteLine("3 - Total Vendido");

            Console.Write("\nDigite a opção desejada:");
            Op = int.Parse(Console.ReadLine());

            switch (Op)
            {
                case 1: // Opção 1
                    Console.Write("\nDigite o número do vendedor: "); // Interface 3
                    NumVend = int.Parse(Console.ReadLine()); // Entrada 2
                    for (int i = 0; i < 4; i++) // Laço 1 - Para
                    {
                        Soma = Soma + MatrizVenda[NumVend, i]; // Processo 1
                    }
                    Console.WriteLine("\nTotal vendido pelo vendedor: " + Soma); // Saída 1
                    Console.ReadLine();
                    break;

                case 2: // Opção 2
                    Console.Write("\nDigite o número do produto: "); // Interface 4
                    NumProd = int.Parse(Console.ReadLine()); // Entrada 3
                    for (int j = 0; j < 3; j++) // Laço 2 - Para
                    {
                        Soma = Soma + MatrizVenda[j, NumProd]; // Processo 2
                    }
                    Console.WriteLine("\nTotal vendido do produto: " + Soma); // Saída 2
                    Console.ReadLine();
                    break;

                case 3: // Opção 3
                    for (int i = 0; i < 4; i++) // Laço 3 - Para
                    {
                        for (int j = 0; j < 3; j++) // Laço 4 - Para
                        {
                            Soma = Soma + MatrizVenda[j, i]; // Processo 3
                        }
                    }
                    Console.WriteLine("\nTotal de vendas: " + Soma); // Saída 3
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida"); // Saída 4
                    Soma = 0;
                    Console.ReadLine();
                    break; // Processo 4
            }
        }
    }
}
