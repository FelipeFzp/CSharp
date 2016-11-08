using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Pessoa /* Especificação da Folder em que a Classe esta*/
{
    class Pessoa
    {
        public string Nome { get; set; }

        public virtual void VerPessoa() // virtual habilita que este metodo seja sobrescrito nas SubClasses
        {                               // asbtract obriga que as SubClasses implementem este metodo
            Console.Write("Pessoa ");
        }
    }
}
