using System;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float troco, valor, resultado;

            Console.Write("O valor do produto é: ");
            valor = float.Parse(Console.ReadLine());

            Console.Write("O valor dado pelo cliente é: ");
            troco = float.Parse(Console.ReadLine());

            if (troco < valor)
            {
                resultado = valor - troco;
                Console.WriteLine("Seu pagamento foi: " + troco + " Esse valor pago é insuficiente. Por favor, pague mais " + resultado+" Para o valor correto.");
                Console.ReadKey();
            }
            else
            {
                resultado = troco - valor;
                Console.WriteLine("Seu troco é de R$ " + resultado + " Reais.." );
                Console.ReadKey();
            }
        }
    }
}
