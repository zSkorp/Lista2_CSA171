using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prova1;
            double prova2;
            Console.WriteLine("Média de avaliações");
            Console.Write("\nDigite a nota da primeira prova: ");
            prova1 = double.Parse(Console.ReadLine());
            prova2 = ((5 * 3) - prova1) / 2;
            Console.WriteLine("\nO aluno precisa tirar, no mínimo {0} na prova P2 para ser aprovado\n", prova2);
        }
    }
}
