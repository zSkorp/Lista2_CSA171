
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prova1;
            double prova2;
            double media;
            Console.WriteLine("Média de avaliações");
            Console.Write("\nDigite a nota da primeira prova: ");
            prova1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a nota da segunda prova: ");
            prova2 = double.Parse(Console.ReadLine());
            media = (prova1 + 2 * prova2) / 3;
            if (media >= 5)
            {
                Console.WriteLine("\nAluno aprovado!\n");
            }
            else
            {
                Console.WriteLine("\nAluno reprovado!\n");
            }
        }
    }
}
