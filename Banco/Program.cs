using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            conta cta;
            double valorOper;

            Console.Write("Digite o número da Conta: ");
            int contaNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular da Conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            string depsn = Console.ReadLine().ToUpper();

            if (depsn == "S" || depsn == "s")
            {
               Console.Write("Digite o valor do depósito Inicial: ");
               double depIni = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                cta = new conta(contaNum, nomeTitular, depIni);
            }
            else
            {
                cta = new conta(contaNum, nomeTitular);
            }

            Console.WriteLine("Conta criada:");
            Console.WriteLine(cta);
            Console.ReadKey();


            bool depok = false;
            while (depok == false)
            {
              Console.Write("Digite uma valor para depósito: ");
                string valorX = Console.ReadLine();
              if (valorX.Where(c => char.IsNumber(c)).Count() > 0)
                {
                   cta.deposito(Double.Parse(valorX));
                    depok = true;
                }
                else
                {
                    Console.WriteLine("Informe um valor de depósito válido seu filha da puta!");
                }

            }



            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(cta);
            Console.ReadKey();


            Console.Write("Digite uma valor para saque: ");
            valorOper = double.Parse(Console.ReadLine());
            cta.saque(valorOper);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(cta);
            Console.ReadKey();



        }
    }
}
