using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Quartos[] vet;
            int nrQuartos = 10;
            vet = new Quartos[nrQuartos];
           // limpar os quartos
            for (int i = 0; i < nrQuartos; i++)
            {
                vet[i] = new Quartos();
                vet[i].ocupado = false;
                vet[i].hospede = " ";
                vet[i].email = " ";
            }



            int N;

            Console.WriteLine("Bem vindos a pensão da Dona Xota Larga");
            Console.Write("Quantos quartos deseja utilizar: ");
            N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                Console.Write("Informe o nome do desocupado: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Informe o número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto].ocupado = true;
                vet[quarto].hospede = nome;
                vet[quarto].email = email;
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Quartos Ocupados");
            // listagem dos quartos ocupados
            for (int i = 0; i < nrQuartos; i++)
            {
                if (vet[i].ocupado == true)
                {
                    Console.WriteLine("Nr. Quarto: " + i);
                    Console.WriteLine("Nome: " + vet[i].hospede);
                    Console.WriteLine("Email: " + vet[i].email);
                }
            }



            Console.ReadKey();


        }
    }
}
