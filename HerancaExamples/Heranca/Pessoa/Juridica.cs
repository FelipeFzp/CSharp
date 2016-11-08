using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Pessoa /* Especificação da Folder em que a Classe esta*/
{
    class Juridica: Pessoa /* Herança de Animal, tem todas funções de Pessoa + as de Juridica*/
    {
        public string CNPJ { get; set; }

        public Juridica(string Nome, string CNPJ)
            :base (Nome) /*Especifica que os Parametros NOME/IDADE vem da SuperClasse*/
        {
            this.CNPJ = CNPJ;
        }

        public void CadastrarCNPJ()
        {

        }

        public override void VerPessoa() // override sobre escreve o metodo da SuperClasse
        {
            base.VerPessoa();
            Console.WriteLine("Juridica");
            Console.WriteLine("CNPJ: ");
        }
    }
}
