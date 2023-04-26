using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            float peso;
            float altura;
            float imc;
            Console.WriteLine("Calculadora de IMC");
            Console.Write("\nDigite seu sexo com F ou M: ");
            Console.Write("\nDigite seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("\nDigite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            if (string = "M")
            {
                if (imc < 20)
                {
                    Console.WriteLine("\nVocê está abaixo do peso!\n");
                }
                else if (20 <= imc && imc < 25)
                {
                    Console.WriteLine("\nVocê está no peso ideal!\n");
                }
                else
                {
                    Console.WriteLine("\nVocê está acima do peso!\n");
                }
            }
            else if (string = "F")
            {
                if (imc < 19)
                {
                    Console.WriteLine("\nVocê está abaixo do peso!\n");
                }
                else if (19 <= imc && imc < 24)
                {
                    Console.WriteLine("\nVocê está no peso ideal!\n");
                }
                else
                {
                    Console.WriteLine("\nVocê está acima do peso!\n");
                }
            }
        }
    }
}
