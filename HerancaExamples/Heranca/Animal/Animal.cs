using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Animal /* Especificação da Folder em que a Classe Animal esta*/
{
    class Animal /* Classe que herda para as subclasses Aves/Mamiferos*/
    {

        public int Age { get; set; }
        public string Name { get; set; }

        public Animal (int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public void viver()
        {

        }
    }
}
