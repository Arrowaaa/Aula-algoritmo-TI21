using System;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a, b, c;
            int menu;

            Console.WriteLine("Welcome Sr.  ");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Cadastrar novo Produto: ");
            Console.WriteLine("2 - Realizar venda de produto: ");
            Console.WriteLine("3 - Gerar relatório do produto: ");
            Console.Write("Escolha a Opção: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine("Você escolheu CADASTRAR um produto? ");
                Console.WriteLine("Qual é o Produto que deseja cadastrar? ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Qual a marca do produto ? ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Qual é o preço do produtor ? ");
                c = float.Parse(Console.ReadLine());


                Console.WriteLine("O produto cadastrado foi: " + a + "\n" + b + "\n" + c);
            }
            else if (menu == 2)
            {
                Console.WriteLine("Você escolheu VENDER/COMPRAR um produto ? ");
                float valor = float.Parse(Console.ReadLine());

            }
            else if (menu == 3)
            {
                Console.WriteLine("Você Escoheu gerar um Relatório do Produto? ");
                float valor = float.Parse(Console.ReadLine());

            }
            else
                Console.WriteLine("Opção inválida. Escolha uma opção válida do menu.");
        }
    }
}
        

        
 