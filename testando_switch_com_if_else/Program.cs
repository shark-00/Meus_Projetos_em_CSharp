using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_switch_com_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            {   // declaraçao de 3 variaves inteira 
                int a, b, c = 0;
                Console.WriteLine("Digite um número: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Agora, o que você quer comesse números? ");
                Console.WriteLine("1 - Verificar se o primeiro número é maior que o segundo número. ");
                Console.WriteLine("2 - Verificar se o segundo número é maior que o primeiro número. ");
                Console.WriteLine("3 - Verificar se os números são iguais. ");
                c = Int32.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        if (a > b)
                        {
                            Console.WriteLine("O primeiro número é maior que o segundo número! ");
                        }
                        else
                        {
                            Console.WriteLine("O primeiro número não é maior que o segundo! ");
                        }
                        break;
                    case 2:
                        if (a < b)
                        {
                            Console.WriteLine("O segundo número é maior que o primeiro número! ");
                        }
                        else
                        {
                            Console.WriteLine("O segundo número não é maior que o primeiro! ");
                        }
                        break;
                    case 3:
                        if (a == b)
                        {
                            Console.WriteLine("Os dois números são iguais! ");
                        }
                        else
                        {
                            Console.WriteLine("Os dois números não são iguais! ");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadLine();
            }
        }
    }
}
