using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Funcionario: Pessoa
    {
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, double salario) 
            : base(nome, idade)
        {
            this.Salario = salario;
        }

        public override string ToString() // deve ser incrementado nos objetos dos tipos especificos como exemplo na classe Funcionario e Pessoa
        {
            return $"Nome: {Nome}, Idade: {Idade}, Salario: {Salario:c}"; // :c Currency Insere a assinatura da moeda do local em que o programa é executado
        }
    }
}
