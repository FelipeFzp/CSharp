using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Pessoa /* Especificação da Folder em que a Classe esta*/
{
    class Fisica: Pessoa /* Herança de Animal, tem todas funções de Pessoa + as de Fisica*/
    {
        public string CPF { get; set; }
        public int Idade { get; set; }

        public Fisica(string Nome, int Idade , string CPF)
            :base(Nome) /*Especifica que os Parametros NOME/IDADE vem da SuperClasse*/
        {
            this.CPF = CPF;
            this.Idade = Idade;
        }

        public void CadastrarCPF()
        {

        }
        public override void VerPessoa() // override sobre escreve o metodo da SuperClasse
        {
            base.VerPessoa();
            Console.WriteLine("Fisica");
            Console.WriteLine("CPF: ");
        }
    }
}
