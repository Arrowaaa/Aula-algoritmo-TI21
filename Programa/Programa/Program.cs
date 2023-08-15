using System;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pagamento, valor, troco;
            int menu;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Média de três Números: ");
            Console.WriteLine("2 - Troco de Compra: ");
            Console.WriteLine("3 - Conversão de Temperatura: ");
            Console.Write("Escolha a Opção: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                float a, b, c;
                float soma, media;

                Console.WriteLine("Digite o 1° Número: ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2° Número: ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 3° Número: ");
                c = float.Parse(Console.ReadLine());

                soma = a + b + c;
                media = soma / 3;

                Console.WriteLine("O Valor da Média é: " + media);
            }
            else if (menu == 2)
            {
                Console.WriteLine("Digite o Valor Total da Compra: ");
                valor = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor pago pelo CLIENTE: ");
                pagamento = float.Parse(Console.ReadLine());

                if (valor > pagamento)
                {
                    Console.WriteLine("O Valor do pagamento é insuficiente para concluir a compra.");
                }
                else
                {
                    troco = pagamento - valor;
                    Console.WriteLine("O Valor do seu troco é R$: " + troco);
                }
            }
            else if (menu == 3)
            {
                float celsius, fahrenheit;
                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = float.Parse(Console.ReadLine());

                fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha uma opção válida do menu.");
            }
        }
    }
}
