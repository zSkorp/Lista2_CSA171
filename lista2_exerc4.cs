using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseR;
            double alturaR;
            Console.WriteLine("Calcular área de um retângulo");
            Console.Write("\nInsira a base: ");
            baseR = double.Parse(Console.ReadLine());
            Console.Write("\nInsira a altura: ");
            alturaR = double.Parse(Console.ReadLine());
            if (baseR * alturaR > 100)
            {
                Console.WriteLine("\nTerreno grande\n");
            }
            else
            {
                Console.WriteLine("\n{0}\n", baseR * alturaR);
            }
        }
    }
}
