using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;
            Console.WriteLine("Descubra o Triângulo");
            Console.Write("\nEntre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o terceiro valor: ");
            valor3 = double.Parse(Console.ReadLine());
            if((valor1 + valor2) < valor3 | (valor1 + valor3) < valor2 | (valor2 + valor3) < valor1)
            {
                Console.WriteLine("\nNão forma-se um triângulo com os valores inseridos\n");
            }
            else if (valor1 == valor2 && valor2 == valor3 && valor1 == valor3)
            {
                Console.WriteLine("\nTriângulo equilátero\n");
            }
            else if (valor1 != valor2 && valor2 != valor3 && valor1 != valor3)
            {
                Console.WriteLine("\nTriângulo escaleno\n");
            }
            else
            {
                Console.WriteLine("\nTriângulo isósceles\n");
            }
        }
    }
}
