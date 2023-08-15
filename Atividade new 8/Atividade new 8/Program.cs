using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade_new_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crianca = 0 a 12
            // adolecente = 13 a 17
            // adulto = 18 a 59
            // idoso = 60 +

            int idade;

            Console.Write("Qual é a sua idade ? ");
            idade = int.Parse(Console.ReadLine());


            if (idade >= 0 && idade <= 12){

                Console.Write("Você possui: "+ idade+ " Você é Criança. ");

            } 
                else if (idade >= 13 && idade <= 17){

                Console.Write("Você possui: "+ idade+ " Você é Adolecente. ");
            }

                else if (idade >= 18 && idade <= 59){
                Console.Write("Você possui: "+ idade+ " Você é Adulto. ");
            }

                else if (idade >= 60)
            {
                Console.Write("Você possui: " + idade + " Você é Idoso. ");
            }
            Console.ReadKey();
        }
    }
}
