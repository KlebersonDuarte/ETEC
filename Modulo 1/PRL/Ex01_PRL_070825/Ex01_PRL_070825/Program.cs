using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PRL_070825
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nome; // Variavel de Texto Entrada

            Console.Clear(); // Limpa Tela
            Console.WriteLine("Digite seu nome:"); // Interface 1
            Console.SetCursorPosition(17, 0); // Posição 1

            Nome = Console.ReadLine(); // Entrada 1

            Console.WriteLine("Bem vindo:" + Nome); // Saída 1
            Console.WriteLine("Na aula de programação e algoritmo"); // Saída 2
            Console.ReadLine();

        }
    }
