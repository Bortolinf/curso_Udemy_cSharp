using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sal = new List<double>();

            Console.WriteLine("Informe a distância dos Saltos ou 'F' para finalizar");
            int Seq = 0;
            bool ficar=true;
       

            while (ficar)
            {
                Seq++;
                Console.Write("Salto " + Seq + ":");
                String entrada = Console.ReadLine();
                if (entrada == "F")
                {
                    ficar = false;
                }else
                {
                    if (entrada.Where(c => char.IsNumber(c)).Count() > 0)
                    {
                        sal.Add(Double.Parse(entrada));
                    }else
                    {
                        Console.WriteLine("Informe um número!");
                        Seq--;
                    }

                }
            }
           
            Console.WriteLine("O melhor salto foi " + sal.Max());
            Console.ReadKey();
        }
    }
}
