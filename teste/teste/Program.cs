using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args);

        int numero1;
        int numero2;
        int numero3;
        int soma, media;

            soma = numero1 + numero2 + numero3;
            media = soma / 3;


            Console.Write("Digite o 1° numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O Valor Digitado foi: " + numero1 + "\n");


            Console.White("Digite o 2° numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.White("O Valor Digitado foi: " + numero2 + "\n");


            Console.White("Digite o 3° numero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.White("O Valor Digitado foi: " + numero3 + "\n");

            Console.White("A Media é: ");
            media = float.Parse(Console.ReadLine());
            Console.White("O Valor Digitado foi: " + media + "\n");






        {
        }
    }
}
