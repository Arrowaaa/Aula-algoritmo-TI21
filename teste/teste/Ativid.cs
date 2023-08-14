using System;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            float soma, media;

            Console.Write("Digite o 1° numero: ");
            numero1 = float.Parse(Console.ReadLine());
            

            Console.Write("Digite o 2° numero: ");
            numero2 = float.Parse(Console.ReadLine());
           

            Console.Write("Digite o 3° numero: ");
            numero3 = float.Parse(Console.ReadLine());
         

            soma = numero1 + numero2 + numero3;
            media = soma / 3;

          

            Console.WriteLine("A Média é: " + media);
            Console.ReadKey();
        }
    }
}
