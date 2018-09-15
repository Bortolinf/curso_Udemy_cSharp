using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace mediaIdades
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, soma, count;
            double media;
            soma = 0;
            count = 0;

           idade = int.Parse(Console.ReadLine());
           while (idade >= 0)
            {
                idade = int.Parse(Console.ReadLine());
                soma = soma + idade;
                count++;

            }

            if (count == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = (double)soma / count;
                Console.Clear();
                Console.WriteLine("A media das idades é: " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
                Console.ReadKey();
        }
    }
}
