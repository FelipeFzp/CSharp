using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions func = new Functions();
            func.ListaPessoas.Add(new Pessoa("Felipe",19));
            func.ListaPessoas.Add(new Funcionario("Felipe", 30,900));
            func.ListaPessoas.Add(new Pessoa("Igor", 18));
            func.ListaPessoas.Add(new Funcionario("Flora", 30, 300));
            func.calcularSalarioFuncionarios();
            Console.ReadKey();
        }
    }
}
