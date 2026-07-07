using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX25_PRL_051125
{
    internal class Program
    {
        public static void Linha()
        {
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
        }
        static void Main(string[] args)
        {
            int Tamanho, Op;
            int Contador = 0;

            try
            {
                Console.Clear();
                Linha();

                Console.Write("\nDigite o tamanho:");
                Tamanho = int.Parse(Console.ReadLine());
                Linha();

                Console.WriteLine("\n1 - Contador Para ");
                Console.WriteLine("2 - Contador Enquanto ");
                Linha();

                Console.Write("\nEscolha uma Opção:");
                Op = int.Parse(Console.ReadLine());
                Linha();

                Console.WriteLine("\nLista:");

                switch (Op)
                {
                    case 1:
                        for (int i = 0;i <= Tamanho; i++)
                        {
                            Console.WriteLine("Número:"+i);
                        }
                        break;
                    case 2:
                        while (Contador < Tamanho)
                        {
                            Console.WriteLine("Número:" + Contador);
                            Contador++;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        Contador =0;
                        break;
                }
        Linha();
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Digite valores númericos");
                Linha();
                Console.ReadLine();
            }

        }

    }
}
