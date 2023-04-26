using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Calcular triângulo retângulo");
            Console.Write("Insira o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            c = double.Parse(Console.ReadLine());
            if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("Os valores formam um triângulo retângulo!");
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo retângulo");
            }
        }
    }
}
