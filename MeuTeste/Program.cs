using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            char c; // Declarando variavel
            string str;
            // Escrevendo no console sem retorno de carro
            Console.Write("Digite seu nome: ");
            // Lê uma string do console.<Enter> para concluir
            str = Console.ReadLine();
            // Escreve no console sem retorno de carro
            Console.Write("Digite uma letra: ");
            // Lê do console um caractere simples.
            c = (char)Console.Read();
            // Escreve uma linha embranco
            Console.WriteLine();
            // Escreve uma string no console
            Console.WriteLine("Seu nome é: {0}", str);
            // Escreve 1 caractere com ToString() para coverter em string
            Console.WriteLine("A letra é: {0},", c.ToString());
            
            Console.ReadLine();
        }
    }
}
