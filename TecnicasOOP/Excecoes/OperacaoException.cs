using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnicasOOP.Excecoes
{
    class OperacaoException : Exception
    {
        public OperacaoException(string mensagem) : base(mensagem)
        {

        }
    }
}
