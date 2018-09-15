using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int volIni = 0;
            int vazao = 0;
            int tempo = 0;
            double resultado;

            Console.Write("Volume Inicial: ");
            volIni = int.Parse(Console.ReadLine());
            Console.Write("Vazao ml/s: ");
            vazao = int.Parse(Console.ReadLine());
            Console.Write("Tempo de Aplicação: ");
            tempo = int.Parse(Console.ReadLine());

            resultado = (double)volIni - (vazao * tempo);

            if (resultado >= 0.00)
            {
            Console.WriteLine("Restou no recipiente: " + resultado + "ml");
            Console.ReadKey();

            }else
            {
            Console.WriteLine("não foi possível calcular");
            Console.ReadKey();
            }
        }
    }
}
