using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercPedido.dominio;



namespace exercPedido
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira Acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofa de tres lugares", 20000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            while (opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                opcao = int.Parse(Console.ReadLine());
                }catch (Exception e)
                {
                    Console.WriteLine("erro inesperado " + e);
                    opcao = 0;
                }


                switch (opcao)
                {
                    // opcao 1
                    case 1:
                        Tela.listarProdutos();
                    break;

                    // opcao 2
                    case 2:
                        try
                        {
                        Tela.cadastrarProduto();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e);
                            Console.ReadLine();
                        }
                    break;

                    // opcao 3
                    case 3:
                        try
                        {
                            Tela.cadastrarPedido();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("erro de negócio: " + e.Message);
                              Console.ReadLine();
                      }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e);
                            Console.ReadLine();
                        }

                        break;

                    // opcao 4
                    case 4:
                        try
                        {
                            Tela.mostrarPedido();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("erro de negócio: " + e.Message);
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e);
                            Console.ReadLine();
                        }

                        break;

                    // opcao 5
                    case 5:
                        Console.WriteLine("Fim do Programa!");
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;


                }


            }

            Console.ReadKey();

        }
    }
}
