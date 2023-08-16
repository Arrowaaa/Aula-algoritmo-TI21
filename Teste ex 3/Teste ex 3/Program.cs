using System;



namespace OrdenarNumerosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita os três números ao usuário

            Console.Write("Digite o 1° número: ");
            int num1 = int.Parse(Console.ReadLine());



            Console.Write("Digite o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());



            Console.Write("Digite o 3° número: ");
            int num3 = int.Parse(Console.ReadLine());



            int menor, meio, maior;



            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
                if (num2 < num3)
                {
                    meio = num2;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num2;
                }
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
                if (num1 < num3)
                {
                    meio = num1;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num1;
                }
            }
            else
            {
                menor = num3;
                if (num1 < num2)
                {
                    meio = num1;
                    maior = num2;
                }
                else
                {
                    meio = num2;
                    maior = num1;
                }
            }



            // Imprime os números em ordem crescente
            Console.WriteLine("Os números em ordem crescente são: " + menor + "-" + meio + "-" + maior);
            Console.ReadKey();
        }
        
        
    }
}
