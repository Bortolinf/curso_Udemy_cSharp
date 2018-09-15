using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercPedido.dominio;

namespace exercPedido
{
    class Tela
    {
        // classe responsavel por coner operacoes que interagem com o usuario
        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Pedido");
            Console.WriteLine("4 - Mostrar dados do Pedido");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Digite uma opção: ");
        }

        public static void listarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS");
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
            Console.ReadKey();

        }


        public static void cadastrarProduto()
        {
            Console.WriteLine();
            Console.Write("Codigo; ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(codigo, descricao, preco);
            Program.produtos.Add(p);
            Program.produtos.Sort();

        } 

        public static void cadastrarPedido()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do Pedido: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido P = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos Itens terá o Pedido: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os dados do item " + i + ":");
                Console.Write("Código do Produto: ");
                int codProduto = int.Parse(Console.ReadLine());
                // alimente a variavel x tal-que x.codigo seja igual ao codigo
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if (pos == -1)
                {
                    throw new ModelException("Código de produto não encontrado " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Percentagem de Desconto: ");
                double pct = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                ItemPedido ip = new ItemPedido(qte, pct, P, Program.produtos[pos]);
                P.itens.Add(ip);
            }

            Program.pedidos.Add(P);

        } 


        public static void mostrarPedido()
        {
            Console.Write("Digite o Código do Pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
            {
                throw new ModelException("Código do pedido não encontrado");
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.ReadKey();
        }


    }
}
