using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Functions
    {
        public List<Pessoa> ListaPessoas = new List<Pessoa>();

        public void calcularSalarioFuncionarios()
        {
            double SomaSalario = 0f;
            foreach(var pessoa in ListaPessoas)
            {
                if (pessoa.Idade>25)
                {
                    var funcionario = pessoa as Funcionario; // se pessoa for um funcionario, a variavel recebe todas propriedades do funcionario senao, recebe null
                    if (funcionario != null)
                    {
                        Console.WriteLine(funcionario.ToString());
                        SomaSalario = SomaSalario + funcionario.Salario;
                        
                    }
                    else
                        Console.WriteLine(pessoa.ToString());
                }
            }
        }



    }
}
