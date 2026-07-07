using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;J
Oamespace Ex04_PRL_170825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double EM;
            double QM;
            double QMx;

            Console.Clear();
            Console.WriteLine("Informe a quantidade média:");
            Console.SetCursorPosition(27,0);
            QM = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima:");
            Console.SetCursorPosition(28, 1);
            QMx = double.Parse(Console.ReadLine());

            EM = (QM + QMx) / 2;
            Console.WriteLine("Estoque médio igual a: "+EM);
            Console.ReadLine();
        }
    }
}
