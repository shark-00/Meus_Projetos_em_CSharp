using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaraçao de variavel
            // Para ler double tem colocar (0;)
            double alcool = 0;
            // Lendo valor do alcool
            Console.Write("Digite valor do alcool: ");
            // Convertendo double em string para fazer a leitura
            alcool = Convert.ToDouble(Console.ReadLine());

            // Pulando linha
            Console.WriteLine();
            // Declaracao de variavel gasolina
            double gasolina = 0;
            Console.Write("Digite valor da gasolina: ");
            gasolina = Convert.ToDouble(Console.ReadLine());

            // Pulando linhas 
            Console.WriteLine();
            Console.WriteLine();

            // Calculando qual mais favoravel usando if else
            if (alcool / gasolina >= 0.7)
            {
                Console.WriteLine(" Melhor abaster na Gasolina");
            }
            else
            {
                Console.WriteLine(" Melhor abaster no Alcool");
            }
            // Pulando linha 
            Console.WriteLine();
            Console.WriteLine("Fim do Programa !");

            

            Console.ReadLine();
           
            

        }
    }
}
