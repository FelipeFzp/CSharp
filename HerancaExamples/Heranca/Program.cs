using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.Ave Bird = new Animal.Ave(6, "Bird" , "Amarelo");
            Animal.Mamifero Mam = new Animal.Mamifero(8 , "Dog" , 4);

            Bird.viver();
            Bird.Fly();

            Mam.viver();
            Mam.run();

            /*--------------------------------------------------------------------------------------------------------------------------*/

            Pessoa.Fisica Fis = new Pessoa.Fisica("Felipe", 19 ,"000.000.000-00");
            Pessoa.Juridica Jur = new Pessoa.Juridica("Promob", "000000-00");

            Fis.VerPessoa();
            Fis.CadastrarCPF();

            Jur.VerPessoa();
            Jur.CadastrarCNPJ();

            

        }
    }
}
