using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL09_PRL_28082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double KWH; /*Preço do consumo de energia por hora */
            double Consumo; /*Consumo de energia */
            const double CIP =29.98; /*Iluminação pública(taxa da prefeitura) */
            double ICMS; /* Imposto Estadual sobre mercadorias e serviços*/
            double V; /*Valor total a ser pago */
            double PIS_PASEP; /*Imposto federal sobre Programa de Integração social e Programa de Formação do Patromônio de Serviço Público */
            double COFINS; /*Imposto federal cobrado com base na receita bruta das empresas. A sigla significa Contribuição para o Financiamento da Seguridade Social */

            Console.BackgroundColor = ConsoleColor.White; /*muda o fundo*/
            Console.Clear();/*limpa a tela*/
            Console.BackgroundColor = ConsoleColor.DarkCyan; /*pinta onde tá as letras*/
            Console.ForegroundColor = ConsoleColor.White; /*muda a cor da fonte*/

            Console.WriteLine("Consumo em horas:");
            Console.SetCursorPosition(18, 0);
            Consumo = double.Parse(Console.ReadLine());

            /*calculos*/        
            KWH = Consumo * 0.86;
            ICMS = Consumo * 0.18;
            PIS_PASEP = Consumo * 0.03;
            COFINS = Consumo * 0.02;
            V = Consumo + KWH + CIP + ICMS + PIS_PASEP + COFINS;
            
            /*mostra*/
            Console.WriteLine("");/*pula uma linha*/
            Console.WriteLine("KWH é igual a:" + KWH);
            Console.WriteLine("Consumo é igual a:" + Consumo);
            Console.WriteLine("CIP é igual a:" + CIP);
            Console.WriteLine("ICMS é igual a: " + ICMS);
            Console.WriteLine("PIS_PASEP é igual a:" + PIS_PASEP);
            Console.WriteLine("COFINS é igual a:" + COFINS);
            Console.WriteLine("Valor total é igual a:" + V);

            Console.ReadLine();

        }
    }
}
