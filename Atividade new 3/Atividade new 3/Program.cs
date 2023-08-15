using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade_new_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;


            Console.Write("Digite o 1° numero: ");
            numero1 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
           

            Console.Write("Digite o 2° numero: ");
            numero2 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
            

            Console.Write("Digite o 3° numero: ");
            numero3 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 


            if (numero1 > numero2 && numero2 > numero3)
            {

                
                Console.WriteLine("Sua numeração foi: " + numero3 + "-" + numero2 + "-" + numero1 + ".");
                Console.WriteLine("Ordem Crescente.");
            }
            else if (numero1 > numero2 && numero1 > numero3)
            {

                Console.WriteLine("Sua numeração foi: " + numero1 + "-" + numero3 + "-" + numero2 + ".");
                Console.WriteLine("Ordem Crescente.");

            }
            else if (numero1 > numero2 && numero2 < numero3)
            {
                
                Console.WriteLine("Sua numeração foi: " + numero1 + "-" + numero3 + "-" + numero2 + ".");
                Console.WriteLine("Ordem Crescente.");
            }
            else if (numero1 < numero2 && numero2 > numero3)
            {
                
                Console.WriteLine("Sua numeração foi: " + numero2 + "-" + numero3 + "-" + numero1 + ".");
                Console.WriteLine("Ordem Crescente.");
            }
            else if (numero2 < numero1 && numero2 > numero3)
            {
                
                Console.WriteLine("Sua numeração foi: " + numero1 + "-" + numero2 + "-" + numero3 + ".");
                Console.WriteLine("Ordem Crescente.");

            }
            else if (numero2 > numero1 && numero1 > numero3)
            {

                Console.WriteLine("Sua numeração foi: " + numero2 + "-" + numero1 + "-" + numero3 + ".");
                Console.WriteLine("Ordem Crescente.");

            }
            else
            {
                
               
                Console.WriteLine("Ordem Decrescente.");


            }
            Console.ReadKey();
        }
    }
}

