using System;

namespace IMCCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC - Índice de Massa Corporal");

            Console.Write("Digite o seu peso (em kg): ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            float altura = float.Parse(Console.ReadLine());

            // Cálculo do IMC
            float imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: "+imc);

            // Classificação do IMC
            if (imc < 16)
            {
                Console.WriteLine("Classificação: Magreza grave");
            }
            else if (imc >= 16 && imc < 17)
            {
                Console.WriteLine("Classificação: Magreza moderada");
            }
            else if (imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("Classificação: Magreza leve");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Classificação: Obesidade grau I");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Classificação: Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
                
            }
            Console.ReadKey();
        }
    }
}
