using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX34_PRL_27112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string Frase, Letra;
                int Tamanho, Contador = 1;





                Console.Write("Digite uma frase: ");

                Frase = (Console.ReadLine());

                Tamanho = Frase.Length;


                for (int i = 0; i < Tamanho; i++)
                {
                    Letra = Frase.Substring(i, 1);
                    if (Letra == " ") Contador++;
                    else if(Frase.Substring(i,1) == " ")
                    {
                        Contador--;
                    }

                }
                Console.Write("Número de palavra(s): " + Contador);
                Console.ReadLine();
                Contador = 0;


            }
        }
        }
    }

