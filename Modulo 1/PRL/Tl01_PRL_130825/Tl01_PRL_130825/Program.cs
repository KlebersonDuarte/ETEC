using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tl01_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero; // Variavel Inteira Entrada

            int Anterior; // Variavel inteira Saida
            int Posterior;// Variavel inteira Saida
            Console.Clear();// Limpa tela
            Console.WriteLine("Digite um número:"); // Interface 1
            Console.SetCursorPosition(17, 0);// Posição 1
            Numero= int.Parse(Console.ReadLine()); // Entrada 1

            Anterior = Numero - 1;// Processo 1
            Posterior = Numero + 1;// Processo 2 

            Console.WriteLine("Vizinhos :" + Anterior + " e " + Posterior);// Saida- Valor concatenado
            Console.ReadLine,)+
        }
    }
}
