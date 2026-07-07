using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX23_PRL_291025
{
    internal class Program
    {
        static void Linha()
        {
            Console.Write("--------------------------------------------------");
        }
        static void Main(string[] args)
        {
            double resultado = 0;
            int figura, op;
            double Valor1,Valor2,Valor3 =0;

            Console.Clear();

            Console.WriteLine("\n<Opções de Figuras>");
            Console.WriteLine("\n1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Retângulo");

            Console.Write("\nDigite a figura digitada: ");

            figura = int.Parse(Console.ReadLine());


            Console.WriteLine("\n<Opções de Operações>");
            Console.WriteLine("\n1 - Área");
            Console.WriteLine("2 - Perímetro");

            Console.WriteLine("\nDigite a operação desejada: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    if(figura == 1)
                    {
                        Console.Write("Digite a base do triângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do triângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = (Valor1 * Valor2) / 2;

                        Console.WriteLine("\nÁrea do triângulo: " +resultado);
                    }
                    else if(figura == 2)
                    {
                        Console.Write("Digite o valor do lado do quadrado: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * Valor1;
                        Console.WriteLine("\nÁrea do quadrado: " + resultado);
                    }
                    else if(figura == 3)
                    {
                        Console.Write("Digite a base do retângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * Valor2;
                        Console.WriteLine("\nÁrea do retângulo: " + resultado);

                    }
                    break;
                case 2:
                    if (figura == 1)
                    {
                        Console.Write("Digite o valor do lado A do triângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do lado B do triângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do lado C do triângulo: ");
                        Valor3 = double.Parse(Console.ReadLine());
                        resultado = Valor1 + Valor2 + Valor3;
                        Console.WriteLine("\nPerímetro do triângulo: " + resultado);
                    }
                    else if (figura == 2)
                    {
                        Console.Write("Digite o valor do lado do quadrado: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * 4;
                        Console.WriteLine("\nPerímetro do quadrado: " + resultado);
                    }
                    else if (figura == 3)
                    {
                        Console.Write("Digite a base do retângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = 2 * (Valor1 + Valor2);
                        Console.WriteLine("\nPerímetro do retângulo: " + resultado);
                    }
                    break;
                default:
                    Console.WriteLine("\nValor digitado não é válido");
                    resultado = 0;
                    break;
            }
            Console.WriteLine("\nResultado:" + resultado);
            Console.ReadLine();
        }
    }
}
