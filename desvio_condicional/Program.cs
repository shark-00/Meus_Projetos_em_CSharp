using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desvio_condicional
{
    class Program
    {
        static void Main(string[] args)
        {   
            // declaraçao de  variavel inteira sem valor 
            int numero = 0;
            Console.WriteLine("Escolha um número: 1, 2,ou 3");
            Console.Write("Digite o número: ");
            // convertendo variavel inteira para string para fazer a leitura do teclado 
            numero = Convert.ToInt32(Console.ReadLine());

            // desvio condional switch, com a leitura da variavel inteira ativa um case diferente
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Você digitou um");
                    break;
                case 2:
                    Console.WriteLine(" Você digitou dois");
                    break;
                case 3:
                    Console.WriteLine("Você digitou três");
                    break;
                default:
                    Console.WriteLine("Número invalido");
                    break;

                        
            }
            /* laço de repetiçao for
             * declaraçao de variavel inteira 0 
             * laço irá conta do 0 ao 4*/
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteração {0}", i);
            }

            /* laço de repetiçao while
             * declaraçao de variavel inteira 0
             * laço ira conta do 0 ao 4*/
            int ii = 0;
            while (ii < 5);
            {
                Console.WriteLine("Iteração {0}", ii);
                // diferente do FOR, while faz a contagem antes
                ii++;
            }
            Console.ReadKey();
        }
    }
}
