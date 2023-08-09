using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float a,b, soma,subtracao, multiplicacao, divisao, resto;

            //Console.Write("Hello World");

            Console.Write("Digite o 1° número: ");
            a = int.Parse (Console.ReadLine() );

            Console.Write("Digite o 2° número: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b; // Estamos somando os valores das variaveis a e b

            Console.Write("A Soma dos Valores São: " + soma +"\n"); // WriteLine ou \n Serve para quebrar a minha linha ao final.

            subtracao = a - b; // Estamos subtraindo os valores das variaveis a e b

            Console.Write("A Subtração dos Valores São: " + subtracao + "\n"); // WriteLine ou \n Serve para quebrar a minha linha ao final.

            multiplicacao = a * b;

            Console.Write("A Multiplicação dos Valores São: " +  multiplicacao + "\n");

            divisao = a / b;

            Console.Write("A Divisão dos Valores São: " + divisao);
          




            Console.ReadKey();













        }
    }
}
