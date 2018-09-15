using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 
   

namespace Banco
{
    class conta
    {

        public int contaNum { get; private set; }
        public string nomeTitular { get; private set; }
        public double saldo { get; private set; }



        // construtor da classe - recebendo deposito inicial
        public conta(int contaNum, string nomeTitular, double depIni)
        {
            this.nomeTitular = nomeTitular;
            this.contaNum = contaNum;
            this.saldo = depIni;
        }

        // construtor sem deposito inicial
        public conta(int contaNum, string nomeTitular)
        {
            this.nomeTitular = nomeTitular;
            this.contaNum = contaNum;
            this.saldo = 0;
        }



        public override string ToString()
        {
            return "Conta: " + contaNum + " Titular: " + nomeTitular
                   + ", Saldo: $" + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


        // metodo p/fazer deposito
        public void deposito(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }

        // metodo p/fazer saque (5 de taxa)
        public void saque(double valorSaque)
        {
            saldo = saldo - valorSaque - 5;
        }




    }
}
