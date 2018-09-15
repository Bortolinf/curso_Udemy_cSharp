using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercPedido.dominio;

namespace exercPedido
{                   // vinculo com a classe IComparable foi utilizado para fazer o sort na classe produto
    class Produto : IComparable
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto (int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo 
                + ", "
                + descricao
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Produto outro = (Produto) obj;
            int resultado = descricao.CompareTo(outro.descricao);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {    // o sinal de - é para retornar a ordem decrescente de preco quando as
                 // descricoes forem iguais
                return -preco.CompareTo(outro.preco);
            }

        }
    }
}
