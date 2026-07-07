using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_PLR_070825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias; // Varíavel Inteira Entrada
            double Horas; // Varável real Entrada

            double Total; // Varíavel real saída

            Console.Clear(); // Limpa a tela
            Console.WriteLine("Digite o N° de dias : "); // Interface 1
            Console.SetCursorPosition(21, 0); // Posição 1
            dias = int.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite o N° de horas : "); // Interface 2
            Console.SetCursorPosition(22, 1); // Posição 2
            Horas = double.Parse(Console.ReadLine()); // Entrada 2

            Total = (dias * 24) + Horas; // Processo 1

            Console.WriteLine("Total de horas " + Total); // Saída 1
            Console.ReadLine();
        }
    }
}
