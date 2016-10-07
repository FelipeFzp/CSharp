using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString() // deve ser incrementado nos objetos dos tipos especificos como exemplo na classe Funcionario e Pessoa
        {
            return $"Nome: {Nome}, Idade: {Idade}, Salario: Desempregado";
        }
    }
}
