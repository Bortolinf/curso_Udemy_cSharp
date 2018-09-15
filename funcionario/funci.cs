using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace funcionario
{
    class funci
    {
        public string nome;
        public double salBruto;
        public double desconto;

        public double salLiquido()
        {
            return salBruto - desconto;
        }

        public override string ToString()
        {
            return "O abostiado se chama: " + nome + " e tem rendimentos liquidos de R$ "
                + salLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


        public void aumentarSalario(double porcentagem)
        {
            salBruto = salBruto + (salBruto * porcentagem / 100);
        }




    }
}
