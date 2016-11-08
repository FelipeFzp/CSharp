using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Animal /* Especificação da Folder em que a Classe Animal esta*/
{
    class Mamifero: Animal /* Herança de Animal, tem todas funções de Mamiferos + as de animal*/
    {
        public int QuantidadePatas { get; set; }

        public Mamifero(int Age, string Name, int QuantidadePatas)
            :base(Age, Name)        /*Especifica que os Parametros NOME/IDADE vem da SuperClasse*/
        {
            this.QuantidadePatas = QuantidadePatas;
        }

        public void run()
        {

        }
    }
}
