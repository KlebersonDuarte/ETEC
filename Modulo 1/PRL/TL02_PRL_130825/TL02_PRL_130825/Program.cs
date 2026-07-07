using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL02_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Conta; // Varíavel Real Entrada
            int Clientes; //Varíavel Inteira Entrada

            double Valor; // Varíavel Real Saída

            Console.Clear();
            Console.WriteLine("Digite o valor da conta R$: ");// Interface 1
            Console.SetCursorPosition(28,0);                                                            
            Conta = double.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite o número de clientes: "); // Entrada 2
            Console.SetCursorPosition(28, 1);
            Clientes = int.Parse(Console.ReadLine()); // Entrada 2

            Valor = Conta / Clientes; //Processo 1
            Console.WriteLine("O valor por cliente será de " + Valor);
            Console.ReadLine();
        }
    }
}
