using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Comparador de valores");
            Console.Write("\nEntre com o primeiro valor: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            y = double.Parse(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("\nOs valores são idênticos ({0})\n", x);
            }
            else if (x > y)
            {
                Console.WriteLine("\nO maior valor é: {0}\n", x);
            }
            else
            {
                Console.WriteLine("\nO maior valor é: {0}\n", y);
            }
        }
    }
}
