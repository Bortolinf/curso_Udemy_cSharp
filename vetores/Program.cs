using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            double soma, media;
            int N;

            Console.Write("Informe o número de pessoas: ");
            N = int.Parse(Console.ReadLine());
            vet = new double[N];


            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / N;

            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

       
            
        }
    }
}
