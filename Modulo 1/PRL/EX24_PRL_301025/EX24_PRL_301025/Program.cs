using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX24_PRL_301025
{
    internal class Program
    {
        static public void Linha()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.Write("=");
            }
        }
        static void Main(string[] args)
        {
            try {
            double resultado = 0;
            int figura, op;
            double Valor1, Valor2, Valor3 = 0;

            Console.Clear();
            Linha();
            Console.WriteLine("\n<Opções de Figuras>");
            Linha();

            Console.WriteLine("\n1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Retângulo");
            Linha();

            Console.Write("\nDigite a figura digitada: ");

            figura = int.Parse(Console.ReadLine());

            Linha();
            Console.WriteLine("\n<Opções de Operações>");
            Linha();

            Console.WriteLine("\n1 - Área");
            Console.WriteLine("2 - Perímetro");
            Linha();

            Console.Write("\nDigite a operação desejada: ");
            op = int.Parse(Console.ReadLine());
            Linha();

            switch (op)
            {
                case 1:
                    if (figura == 1)
                    {

                        Console.Write("\nDigite a base do triângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do triângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = (Valor1 * Valor2) / 2;
                        Linha();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nÁrea do triângulo: " + resultado);
                            Console.ForegroundColor = ConsoleColor.White;
                            Linha();
                    }
                    else if (figura == 2)
                    {

                        Console.Write("\nDigite o valor do lado do quadrado: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * Valor1;
                        Linha();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nÁrea do quadrado: " + resultado);
                            Console.ForegroundColor = ConsoleColor.White;
                            Linha();
                    }
                    else if (figura == 3)
                    {

                        Console.Write("\nDigite a base do retângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * Valor2;
                        Linha();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nÁrea do retângulo: " + resultado);
                            Console.ForegroundColor = ConsoleColor.White;
                            Linha();
                    }

                        else if (figura != 1 || figura != 2 || figura != 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDesculpe mas o valor digitado não é válido");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                case 2:
                    if (figura == 1)
                    {
                        Console.Write("\nDigite o valor do lado A do triângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do lado B do triângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do lado C do triângulo: ");
                        Valor3 = double.Parse(Console.ReadLine());



                        if (Valor1 + Valor2 > Valor3 && Valor1 + Valor3 > Valor2 && Valor2 + Valor3> Valor1) {
                        resultado = Valor1 + Valor2 + Valor3;
                            Linha();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPerímetro do triângulo: " + resultado);
                                Console.ForegroundColor = ConsoleColor.White;
                                Linha();
                            }
                        else {
                                Linha();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nOs valores digitados não formam um triângulo válido.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Linha();
                            }
                    }
                    else if (figura == 2)
                    {

                        Console.Write("\nDigite o valor do lado do quadrado: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        resultado = Valor1 * 4;
                        Linha();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPerímetro do quadrado: " + resultado);
                            Console.ForegroundColor = ConsoleColor.White;
                            Linha();
                        }
                    else if (figura == 3)
                    {

                        Console.Write("\nDigite a base do retângulo: ");
                        Valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        Valor2 = double.Parse(Console.ReadLine());
                        resultado = 2 * (Valor1 + Valor2);
                        Linha();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPerímetro do retângulo: " + resultado);
                            Console.ForegroundColor = ConsoleColor.White;
                            Linha();
                        }


                        else if (figura != 1 && figura != 2 && figura != 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDesculpe mas o valor digitado não é válido");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDesculpe mas o valor digitado não é válido");
                        Console.ForegroundColor = ConsoleColor.White;
                        Linha();
                    break;
            }
            }
            catch (Exception) { 
                Linha();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDesculpe, ocorreu um erro na entrada de dados. Certifique-se de digitar números válidos.");
                Console.ForegroundColor = ConsoleColor.White;
                Linha();
            }
            Console.ReadLine();
        }
    }
}
