using System.Globalization;

namespace estoque
{
     class Produto
    {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }



        // construtor da classe Produto - recebendo argumentos
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        // construtor com apenas dois parametros
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }


        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }
            


        public override string ToString()
        {
            return "Dados do Produto: " + nome + ", Preço R$ " + preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", Saldo em Estoque:" + quantidadeEmEstoque
                   + " Valor Total em Estoque: " + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


        // metodo p/fazer entrada
        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }


        // metodo p/fazer saida
        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

    }
}
