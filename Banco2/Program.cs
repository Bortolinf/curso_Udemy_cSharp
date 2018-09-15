using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Informe o limite para saque: ");

            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numero, titular, limite);


            Console.WriteLine();
            Console.Write("informe um valor para depósito: ");
            double valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.depositar(valordeposito);
            Console.WriteLine("Novo saldo = R$ " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
          
            Console.WriteLine();
            Console.Write("informe um valor para saque: ");
            double valorsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
               c.sacar(valorsaque);
               Console.WriteLine("Novo saldo = R$ " + c.saldo);
            }
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadKey();

        }
    }
}
