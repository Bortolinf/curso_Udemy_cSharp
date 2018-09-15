using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P;
            int qte;
            int qts;

            Console.WriteLine("Digite os dados do Produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           // Console.Write("Quantidade Estoque: ");
          //  int quantidade = int.Parse(Console.ReadLine());
          //  P = new Produto(nome, preco, quantidade);
            P = new Produto(nome, preco);

            Console.WriteLine("Você digitou: " + P.nome + ", " + P.preco.ToString("F2") + ", " + P.quantidadeEmEstoque);
            Console.WriteLine(P);

            Console.WriteLine();

            Console.Write("Digite a quantidade que entrou no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);
            Console.WriteLine(P);

            Console.ReadKey();

            Console.Write("Digite a quantidade que saiu do estoque: ");
            qts = int.Parse(Console.ReadLine());
            P.realizarSaida(qts);
            Console.WriteLine(P);
            Console.ReadKey();

            


        }
    }
}
