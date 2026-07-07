using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_PRL_250925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Op; // Variavel de Entrada -Inteira
            double Valor1, Valor2; // Variavel real - Entr
            double Resultado = 0; // Variavel real - Saida

            Console.Clear(); // Limpa Tela
            Console.Write("Digite o 1º valor:"); // interface 1
            Valor1 = double.Parse(Console.ReadLine()); // Entrada
            Console.Write("Digite o 2º valor:"); // interface 2
            Valor2 = double.Parse(Console.ReadLine()); // Entrada 2


            Console.WriteLine("Digite o 1º valor: "); // interface 1
            Console.WriteLine("\nEscolha uma opção: "); // Interface
            Console.WriteLine("1 - Adição "); // Interface 4
            Console.WriteLine("2 - Multiplicação "); // Interface 5
            Console.WriteLine("3 - Subtração "); // Interface 6
            Console.WriteLine("4 - Divisão "); // Interface
            Console.WriteLine("5 - Resto da Divisão "); // Interface 8
            Console.WriteLine("6 - Potência "); // Interface 9
            Console.WriteLine("7 - Raiz "); // Interface 10
            Console.WriteLine("Digite a opção desejada:"); // Interface 11
            Console.SetCursorPosition(24, 12); // Posição 3
            Op = int.Parse(Console.ReadLine()); // Entrada 3

            switch (Op) // Dispositivo de escolha
            {
            case 1: // Opção 1
                Resultado = Valor1 + Valor2; // Processamento 1
                break; // Fim do Case 1

            case 2: // Opção 2
                Resultado = Valor1 * Valor2; // Processamento 2
                break; // Fim do Case 2

            case 3: // Opção 3
                Resultado = Valor1 - Valor2; // Processamento 3
                break; // Fim do Case 3

            case 4: // Opção 4
                Resultado = Valor1 / Valor2; // Processamento 4
                break; // Fim do Case 4

            case 5: // Opção 5
                Resultado = Valor1 % Valor2; // Processamento 5
                break; // Fim do Case 5

            case 6: // Opção 6
                Resultado = Math.Pow(Valor1, Valor2); // Processamento 6
                break; // Fim do Case 6

            case 7: // Opção 7
                Resultado = Math.Sqrt(Valor1); // Processamento 7
                break; // Fim do Case 7
            }
            Console.WriteLine("Resultado:" +Resultado); // Saída
            Console.ReadLine();
        }
    }
}
