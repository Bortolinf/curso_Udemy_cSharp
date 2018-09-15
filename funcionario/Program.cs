using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            funci f1;
            f1 = new funci();
            double porcent;

            Console.WriteLine("Informe o nome do boneco: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Informe o salário Bruto do vivente: ");
            f1.salBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a bosta dos descontos: ");
            f1.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f1);


            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Informe o percentual de reajuste: ");
            porcent = double.Parse(Console.ReadLine());
            f1.aumentarSalario(porcent);
            Console.WriteLine(f1);
         
            Console.ReadKey();



        }
    }
}
