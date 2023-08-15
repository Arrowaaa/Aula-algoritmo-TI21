using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_new_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;



            Console.Write("o primeiro lado do triângulo? (A): ");
            a = int.Parse(Console.ReadLine());

            Console.Write("o segundo lado do triângulo?  (B): ");
            b = int.Parse(Console.ReadLine());

            Console.Write("o terceiro lado do triângulo? (C: ");
            c = int.Parse(Console.ReadLine());


            if (a == b || a == c) {

                Console.Write("Este triângulo é Equilátero \n");

            }
            else if (a == b || b == c || c == a)
            {
            Console.Write("Este triângulo é Isósceles \n");

            }
            else
            {
                Console.Write("Este triângulo é Escaleno \n");

            }
            Console.ReadKey();
        }



    }
}

