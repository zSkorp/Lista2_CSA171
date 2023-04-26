using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            Console.WriteLine("Comparador de valores");
            Console.Write("\nEntre com o primeiro valor: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o terceiro valor: ");
            z = double.Parse(Console.ReadLine());
            if (x > y && x >  z || x == y && x > z || x == z && x > y)
            {
                    Console.WriteLine("\nO maior valor é: {0}\n", x);
            }
            else if (y > x && y > z || y == z && y > x)
            {
                Console.WriteLine("\nO maior valor é: {0}\n", y);
            }
            else if (z > x && z > y)
            {
                Console.WriteLine("\nO maior valor é: {0}\n", z);
            }
            else
            {
                Console.WriteLine("\nOs valores são idênticos ({0})\n", x);
            }
        }
    }
}
