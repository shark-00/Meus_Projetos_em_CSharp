using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {   // declaraçao de variavel gasolina
            double gasolina = 0;
            // lendo variavel gasolina
            Console.Write("Quanto Km faz com litro de gasolina: ");
            // convertendo double em string para fazer a leitura 
            gasolina = Convert.ToDouble(Console.ReadLine());

            // pulando linha
            Console.WriteLine();

            // declaraçao variavel alcool
            double alcool = 0;
            // lendo a variavel alcool
            Console.Write("Quanto Km faz com litro de alcool: ");
            // convertendo a variavel em string para fazer a leitura 
            alcool = Convert.ToDouble(Console.ReadLine());

            // pulando linha
            Console.WriteLine();

            // declarançao variavel quantidade
            double quantidade = 0;
            // lendo a declaraçao quantidade
            Console.Write("Digite quantidade em litros para abastecer:");
            // convertendo a variavel em string
            quantidade = Convert.ToDouble(Console.ReadLine());
            
            // pulando linha
            Console.WriteLine();
            // declarando nova variavel gasolina 
            // declarando nova variavel alcool
            gasolina = gasolina * quantidade;
            alcool = alcool * quantidade;
            Console.WriteLine("O carro andara: {0} km na gasolina e: {1} km no alcool", gasolina, alcool);

            // pulando linha
            Console.WriteLine();

            // voltando a variavel gasolina e alcool ao valor inicial para obter no calculo
            gasolina = gasolina / quantidade;
            alcool = alcool / quantidade;

            // declaraçao de variavel valor da gasolina
            double valorg = 0;
            // lendo a variavel valor
            Console.Write("Digite valor do litro da gasolina: ");
            // convertendo a variavel valor 
            valorg = Convert.ToDouble(Console.ReadLine());

            // pulando linha 
            Console.WriteLine();

            // declaraçao de variavel valor alcool
            double valora = 0;
            // lendo a variavel valor alcool
            Console.Write("Digite valor do litro do alcool: ");
            // convertendo variavel valor
            valora = Convert.ToDouble(Console.ReadLine());

            // pulando linha
            Console.WriteLine();

            // fazendo a calculo com if e else 
            /* teoria é o alcool se mais barato 70% do que a gasolina 
             e fazer mais quilometragem*/
            if (valora* quantidade / valorg * quantidade < 0.70)
            {
                Console.WriteLine("Melhor abastecer alcool, valor mais favoravel");
            }
            else if ((gasolina * quantidade) / (alcool * quantidade) >= 0.30 )
            {
                Console.WriteLine("Melhor abastecer gasolina, quilometragem maior");
            }
            else 
            {  
                Console.WriteLine("Melhor abastecer alcool, valor favoravel e quilometragem maior");    
            }

            
            Console.ReadLine();

        }
    }
}
