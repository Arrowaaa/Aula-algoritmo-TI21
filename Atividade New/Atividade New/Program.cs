using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_New
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            
              
            if (numero % 2 == 0){
             
                Console.Write("O número: "+ numero+ " É Par. \n");
                

            }
            else {
            
                Console.Write("O número: "+ numero+ " É Impar. \n");
               
            }
            Console.ReadKey();  
        }
    }
}
