using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL07_PRL_27082025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double CF;
            double IMP;
            double PD;
            double PC;
                
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;            
            Console.WriteLine("Custo de fabricação do automovel: ");
            Console.SetCursorPosition(34, 0);
            CF = double.Parse(Console.ReadLine());

            IMP = CF * 0.42;
            PD = CF * 0.15;
            PC = CF + IMP + PD;
            
            Console.WriteLine("O imposto é igual a :" + IMP);
            Console.WriteLine("Porcentagem ao destribuidor é:" + PD);
            Console.WriteLine("Preço ao consumidor:" + PC);

            Console.ReadLine();



        }
    }
}
