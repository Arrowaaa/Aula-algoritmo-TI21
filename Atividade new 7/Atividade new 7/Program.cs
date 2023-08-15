using System;

namespace LeapYearChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Ano Bissexto");

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());



            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("Esse Ano "+ano+" É bissexto.");
            }
            else
            {
                Console.WriteLine("Esse Ano " + ano + " Não é bissexto.");
            }
            Console.ReadKey();
        }
             

}
}
