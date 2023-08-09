using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World "); //Console.Write Console para termos interações com o console e Write serve para escrever no console.
            //Console.ReadKey(); // Readkey ler somente a tecla
            //Console.WriteLine(); // ler a sequência de caracter digitados pelo o usuário

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma1,soma2,somatotal;
           


            Console.Write("Digite o 1° numero: ");
            numero1 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
            Console.WriteLine("O Valor digitado foi: " + numero1 + "\n");

            Console.Write("Digite o 2° numero: ");
            numero2 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
            Console.WriteLine("O Valor digitado foi: " + numero2 + "\n");

            Console.Write("Digite o 3° numero: ");
            numero3 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
            Console.WriteLine("O Valor digitado foi: " + numero3 + "\n");

            Console.Write("Digite o 4° numero: ");
            numero4 = int.Parse(Console.ReadLine()); // le a sequência de caracter digitado pelo usuario 
            Console.WriteLine("O Valor digitado foi: " + numero4 + "\n");


            soma1 = numero1 + numero2;
            soma2 = numero3 + numero4;
            somatotal = soma1 + soma2;

            Console.WriteLine("O Soma total foi : " + somatotal);



            //int.Parse Converte uma cadeia de caracter para o tipo INTEIRO
            //Estamos o sinal de + para concatenar (junção) o texto digitado + o valor da variavel "numero1"
            

            Console.ReadKey(); // Nesse momento o Readkey serve para o nosso programa não fechar

        }
    }
}
