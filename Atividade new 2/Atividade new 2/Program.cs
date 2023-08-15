using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_new_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18) {
                Console.WriteLine("Você tem "+idade +" Você é maior de idade.");
            }
            else {
                Console.WriteLine("Você tem " + idade + " Você não é maior de idade.");
               
             }
            Console.ReadKey();

        }
    }
}
