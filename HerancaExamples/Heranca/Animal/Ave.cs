using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Animal /* Especificação da Folder em que a Classe Animal esta*/
{
    class Ave: Animal /* Herança de Animal, tem todas funções de aves + as de animal*/
    {
        public string CorPenas { get; set; }

        public Ave(int Age, string Name, string CorPenas)
            :base(Age, Name)            /*Especifica que os Parametros NOME/IDADE vem da SuperClasse*/
        {
            this.CorPenas = CorPenas;
        }      

        public void Fly()
        {
            
        }
        
    }
}
