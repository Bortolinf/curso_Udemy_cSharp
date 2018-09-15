using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;

            double soma, media;
            int N;

            Console.Write("Informe o número de produtos: ");
            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
               Console.Write("Informe o preço: ");
               double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.Write("Informe o produto: ");
               string nome = Console.ReadLine();
               vet[i] = new Produto(nome, preco);

            }

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i].preco;
            }

            media = soma / N;

            Console.WriteLine("Preço médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
