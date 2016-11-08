using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasatroFuncionarios
{
    class Pessoas
    {
        public static List<string> ListaPessoas = new List<string>();
        public static List<string> ListaPessoasCSV = new List<string>();

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public Pessoas (string nome, int idade, string cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Idade: {Idade} | Cpf: {Cpf} | Salario: Desempregado";
        }

        public virtual string ToCSV()
        {
            return $"{Nome};{Idade};{Cpf};Desempregado";
        }
    }
}
