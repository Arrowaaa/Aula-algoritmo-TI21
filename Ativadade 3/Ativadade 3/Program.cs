using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativadade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;

            Console.Write("Digite a temperatura em celsius: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);



            Console.ReadKey();
        


    }
    }
}
