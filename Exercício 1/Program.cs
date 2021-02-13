using System;
using System.Globalization;
namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemento = 0;
            double maior = 0;
            double[] numeros;

            int n = int.Parse(Console.ReadLine());

            numeros = new double[n];

            string[] vetor = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(vetor[i], CultureInfo.InvariantCulture);
                if(maior ==0)
                {
                    maior = numeros[i];
                }
                else if(maior<numeros[i])
                {
                    maior = numeros[i];
                    elemento = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(elemento);

        }
    }
}
