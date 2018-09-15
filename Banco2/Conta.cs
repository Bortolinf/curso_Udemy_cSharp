using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; private set; }
        public double limiteDeSaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeSaque = limiteDeSaque;
            this.saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public void sacar(double valor)
        {
            if(saldo < valor)
            {     // se cais nesta condicao ele corta a execucao por aqui - nao precisa IF encadeado
                throw new OperacaoException("Não há saldo suficiente!");
            }
            if(valor > limiteDeSaque)
            {
                throw new OperacaoException("Valor do saque acima do limite!");
            }
            saldo = saldo - valor;
        }


    }
}
