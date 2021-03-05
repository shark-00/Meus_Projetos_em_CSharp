using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade; // Declaraçao de variavel inteira
            idade = 15;

            // Escrevendo no console
            Console.WriteLine("Programa Idade versão 1.0");
            // Pula linha
            Console.WriteLine();
            // Escrevendo variavel int idade 
            /*Os programas MeuTeste e Idade_v1 tambem introduzem o conceito
             de mascara de exibiçao de valores ({0}). O conteudo das chaves 
            ({0}) é substituido pelo o conteudo da variavel passada como 
            parametro : console.writeline("A idade ano que vem é: {0}", idade);
            */
            Console.WriteLine("A idade atual é: {0}", idade);
            // Pula linha
            Console.WriteLine();
            // Soma da variavel + 1
            idade = idade + 1;
            // Escrevendo resultado 
            Console.WriteLine("A idade ano que vem é: {0}", idade);

            // Novo programa Idade_V1.01
            // Pulando linhas
            Console.WriteLine();
            Console.WriteLine();
            // Declara idade
            int idade1, idadeanoquevem; // Duas variaveis inteira
            idade1 = 15;
            idadeanoquevem = idade1 + 1;
            // EScrevendo no console 
            Console.WriteLine("Programa Idade versao 1.01");
            // Pulando linha
            Console.WriteLine();
            // Somando idade + idadeanoquevem
            Console.WriteLine("A idade atual é {0} e ano que vem será {1}",
                idade1, idadeanoquevem); // Adicionar os parametros ({0}), ({1})
            Console.WriteLine();
            // Pausando programa
            Console.ReadLine();
        }
    }
}
