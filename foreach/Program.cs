using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
        // ([] veto) 
        string[] texto = new string[5];
        texto[0] = "palavra 1";
        texto[1] = "palavra 2";
        texto[2] = "palavra 3";
        texto[3] = "palavra 4";
        texto[4] = "palavra 5";
        int contador = 0;

        foreach ( string palavra in texto)
        {
            Console.WriteLine("Iteração {0}: {1}", contador, palavra);
            contador++;
        }
        Console.ReadKey();
        Console.ReadLine();
        
        }
    }
}
