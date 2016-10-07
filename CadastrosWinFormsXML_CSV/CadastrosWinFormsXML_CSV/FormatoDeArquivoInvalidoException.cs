using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasatroFuncionarios
{
    class FormatoDeArquivoInvalidoException: Exception
    {
        public FormatoDeArquivoInvalidoException()
            :base("Formato do arquivo Inválido")
        {

        }

    }
}
