using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_PRL_040925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Moto; //variavel da moto real
            double Auto; //variavel do automóvel real
            double Bike; // variavel da bicicleta real
            double Metros; // variavel dos metros real
            double Km; // variavel dos Km real
            Console.Clear(); // limpa tela
            Console.WriteLine("Percurso diário da moto em metros : "); // pergunta percurso diário da moto
            Console.SetCursorPosition(35 , 0); //posiciona onde escreve
            Moto = double.Parse(Console.ReadLine());  // lê variavel

            Console.WriteLine("Percurso diário da bicicleta em metros : "); // pergunta percurso diário da bicicleta
            Console.SetCursorPosition(40, 1); //posiciona onde escreve
            Bike = double.Parse(Console.ReadLine()); // lê variavel

            Console.WriteLine("Percurso diário do automóvel em metros : "); // pergunta percurso diário do automóvel
            Console.SetCursorPosition(40 , 2); //posiciona onde escreve
            Auto = double.Parse(Console.ReadLine()); // lê variavel

            Metros = Moto+Auto+Bike; // calcula valor de metros somando variaveis
            Km = Metros / 1000; // calcula valor de km dividindo metros
            Console.WriteLine("Percurso em Km é igual a: "+ Km);// mostra valor de km
            Console.ReadLine(); // lê variavel
        }
    }
}
