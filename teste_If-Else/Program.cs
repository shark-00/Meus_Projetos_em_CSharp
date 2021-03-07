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
        {
            double gasolina = 0;
            Console.Write("Digite consumo na gasolina: ");
            gasolina = Convert.ToDouble(Console.ReadLine());

            double alcool = 0;
            Console.Write("Digite consumo no alcool: ");
            alcool = Convert.ToDouble(Console.ReadLine());

            double quantidade = 0;
            Console.Write("Digite quantidade em litros para abastecer:");
            quantidade = Convert.ToDouble(Console.ReadLine());

            if (gasolina * quantidade > alcool * quantidade * quantidade)
            {
                Console.WriteLine("Melhor abastecer gasolina");
            }
            else 
            {  
                Console.WriteLine("Melhor abastecer alcool");    
            }
            Console.ReadLine();

        }
    }
}
