using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_new_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nota;

            Console.Write("Digite a Sua Nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 9) 
            {
                Console.WriteLine("Sua nota é "+ nota+" A.");
            }
            else if (nota == 7 || nota == 8)
            {
                Console.WriteLine("Sua nota é " + nota + " B.");

            }
            else if (nota == 5 || nota == 6)
            {
                Console.WriteLine("Sua nota é " + nota + " C.");

            }
            else if (nota == 3 || nota == 4)
            {
                Console.WriteLine("Sua nota é " + nota + " D.");

            }
            else if(nota == 2 || nota == 1 || nota == 0)
            {
                Console.WriteLine("Sua nota é " + nota + " F.");
            }
         Console.ReadKey();
        }
    }
}
