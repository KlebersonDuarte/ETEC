using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EX21B_PRL_231025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int tamanho;

            double soma = 0;
            int contador = 1;

            double media;

            Console.Write("Digite o tamanho da lista:");
            tamanho = int.Parse(Console.ReadLine());

            while (contador <= tamanho) {

                Console.Write("Digite um numero: ");
                numero = double.Parse(Console.ReadLine());

                soma = soma + numero; 

                contador++;

        }
            media = soma / tamanho;
            Console.Write("Média:" + media);
            Console.ReadLine();
        }

    }
}
