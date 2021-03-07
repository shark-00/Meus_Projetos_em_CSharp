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
            Console.Write("Quanto Km faz com litro de gasolina: ");
            gasolina = Convert.ToDouble(Console.ReadLine());

            double alcool = 0;
            Console.Write("Quanto Km faz com litro de alcool: ");
            alcool = Convert.ToDouble(Console.ReadLine());

            double quantidade = 0;
            Console.Write("Digite quantidade em litros para abastecer:");
            quantidade = Convert.ToDouble(Console.ReadLine());

            double valorg = 0;
            Console.Write("Digite valor do litro da gasolina: ");
            valorg = Convert.ToDouble(Console.ReadLine());

            double valora = 0;
            Console.Write("Digite valor do litro do alcool: ");
            valora = Convert.ToDouble(Console.ReadLine());

            if (gasolina * quantidade * 0.65 >= alcool * quantidade)
            {
                Console.WriteLine("Melhor abastecer gasolina");
            }
            else if ((valora * quantidade) / (valorg * quantidade) > 0.65)
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
