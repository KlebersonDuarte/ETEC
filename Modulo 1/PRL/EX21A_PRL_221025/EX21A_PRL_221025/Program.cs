using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX21A_PRL_221025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numero;
            double media;
            double soma = 0;


            Console.Clear();
            Console.Write("Digite o tamanho da lista:");
            int tamanho = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tamanho; i++)
            {
                Console.Write("Digite um número:");
                numero = double.Parse(Console.ReadLine());

                soma = soma + numero;
            }

            media = soma / tamanho;
            Console.Write("Média:1" + media);
            Console.ReadLine();
        }
    }
}
