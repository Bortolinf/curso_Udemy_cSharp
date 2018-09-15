using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    class OperacaoException : Exception
    {
        public OperacaoException(string msg): base(msg)
        {

        }
    }
}
