using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasatroFuncionarios
{
    class Funcionario: Pessoas
    {
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, string cpf, double salario) 
            :base(nome, idade, cpf)
        {
            this.Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Idade: {Idade} | Cpf: {Cpf} | Salário: {Salario}";
        }

        public override string ToCSV()
        {
            return $"{Nome};{Idade};{Cpf};{Salario}";
        }

    }
}
