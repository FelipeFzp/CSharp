using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CasatroFuncionarios
{
    public static class Utilidades
    {
        #region Adicionar Objetos
        public static void adicionarFuncionario(string nome, int idade, string cpf, double salario)
        {
            Form1 form1 = new Form1();
            Funcionario funcionario = new Funcionario(nome,idade,cpf,salario);
            Pessoas.ListaPessoas.Add(funcionario.ToString());
            Pessoas.ListaPessoasCSV.Add(funcionario.ToCSV());
        }

        public static void adicionarPessoa(string nome, int idade, string cpf)
        {
            Form1 form1 = new Form1();
            Pessoas pessoa = new Pessoas(nome, idade, cpf);
            Pessoas.ListaPessoas.Add(pessoa.ToString());
            Pessoas.ListaPessoasCSV.Add(pessoa.ToCSV());
        }
        #endregion

        #region Salvar Arquivos
        public static void SalvarArquivos()
        {
            Form1 form1 = new Form1();
            form1.saveFileDialog1.Filter = "Arquivo XML|*.xml | Arquivo CSV|*.csv";
            form1.saveFileDialog1.DefaultExt = "Arquivo XML|*.xml";
            form1.saveFileDialog1.Title = "Selecione o local para salvar seu arquivo";
            var ResultadoDeJanela=form1.saveFileDialog1.ShowDialog();
            var local = form1.saveFileDialog1.FileName; // retorna o local em que o arquivo foi salvo
            string extensaoArquivoSalvo=Path.GetExtension(local); // pega a extensão do caminho passado nos parametros
            if (ResultadoDeJanela.Equals(DialogResult.OK))
            {
                switch (extensaoArquivoSalvo)
                {
                    case ".xml":
                        SalvarListaPessoasXML(local);
                        break;
                    case ".csv":
                        SalvarListaPessoasCSV(local);
                        break;
                    default:
                        MessageBox.Show("Formato de Arquivo Invalido !");
                        break;
                }
            }      
        }

        public static void SalvarListaPessoasCSV(string local)
        {
            File.WriteAllLines(local, Pessoas.ListaPessoasCSV);
        }

        public static void SalvarListaPessoasXML(string local)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode pessoas = doc.CreateElement("PESSOAS"); // raiz
            string[] Informacoes;
            foreach(var linha in Pessoas.ListaPessoasCSV)
            {
                Informacoes = linha.Split(';');
                if (!Informacoes[3].Equals("Desempregado")) // se tiver salario
                {
                    XmlNode funcionario = doc.CreateElement("FUNCIONARIO");

                    XmlAttribute nome = doc.CreateAttribute("NOME");
                    XmlAttribute idade = doc.CreateAttribute("IDADE");
                    XmlAttribute cpf = doc.CreateAttribute("CPF");
                    XmlAttribute salario = doc.CreateAttribute("SALARIO");

                    nome.Value = Informacoes[0];
                    idade.Value = Informacoes[1];
                    cpf.Value = Informacoes[2];
                    salario.Value = Informacoes[3];

                    funcionario.Attributes.Append(nome);
                    funcionario.Attributes.Append(idade);
                    funcionario.Attributes.Append(cpf);
                    funcionario.Attributes.Append(salario);

                    pessoas.AppendChild(funcionario);
                    doc.AppendChild(pessoas);

                    doc.Save(local);
                }
                else
                {
                    XmlNode pessoa = doc.CreateElement("PESSOA");

                    XmlAttribute nome = doc.CreateAttribute("NOME");
                    XmlAttribute idade = doc.CreateAttribute("IDADE");
                    XmlAttribute cpf = doc.CreateAttribute("CPF");

                    nome.Value = Informacoes[0];
                    idade.Value = Informacoes[1];
                    cpf.Value = Informacoes[2];

                    pessoa.Attributes.Append(nome);
                    pessoa.Attributes.Append(idade);
                    pessoa.Attributes.Append(cpf);

                    pessoas.AppendChild(pessoa);
                    doc.AppendChild(pessoas);

                    doc.Save(local);
                }
            }
        }
        #endregion

        #region Carregar Arquivos
        public static void CarregarArquivos()
        {
            Form1 form1 = new Form1();
            form1.openFileDialog1.Filter = "Todos Arquivos | *.*";
            form1.openFileDialog1.Title = "Selecione um Arquivo";
            var ResultadoDaJanela = form1.openFileDialog1.ShowDialog();
            var local=form1.openFileDialog1.FileName;
            var extensaoArquivoAberto = Path.GetExtension(local);
            if (ResultadoDaJanela.Equals(DialogResult.OK))
            {
                switch (extensaoArquivoAberto)
                {
                    case ".xml":
                        CarregarArquivoXML(local);
                        break;
                    case ".csv":
                        CarregarArquivoCSV(local);
                        break;
                    default:
                        throw new FormatoDeArquivoInvalidoException();
                }
            }  
        }

        public static void CarregarArquivoCSV(string local)
        {
            string[] LinhasArquivoCSV = File.ReadAllLines(local);
            string[] VetorInformacoes;
            Pessoas.ListaPessoas.Clear();
            Pessoas.ListaPessoasCSV.Clear();
            foreach (var linha in LinhasArquivoCSV)
            {
                VetorInformacoes = linha.Split(';');
                if (VetorInformacoes[3].Equals("Desempregado"))
                {
                    adicionarPessoa(VetorInformacoes[0], int.Parse(VetorInformacoes[1]), VetorInformacoes[2]);
                }
                else if (!VetorInformacoes[3].Equals("Desempregado"))
                {
                    adicionarFuncionario(VetorInformacoes[0], int.Parse(VetorInformacoes[1]), VetorInformacoes[2], double.Parse(VetorInformacoes[3]));
                }
            }
        }

        public static void CarregarArquivoXML(string local)
        {
            XmlDocument doc = new XmlDocument();
            string nome = string.Empty;
            string idade = string.Empty;
            string cpf = string.Empty;
            string salario = string.Empty;
            Pessoas.ListaPessoas.Clear();
            Pessoas.ListaPessoasCSV.Clear();
            doc.Load(local);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlAttribute atributo in node.Attributes)
                {
                    switch (atributo.Name)
                    {
                        case "NOME":
                            nome = atributo.Value;
                            break;
                        case "IDADE":
                            idade = atributo.Value;
                            break;
                        case "CPF":
                            cpf = atributo.Value;
                            break;
                        case "SALARIO":
                            salario = atributo.Value;
                            break;
                    }
                }
                if (salario != string.Empty)
                    adicionarFuncionario(nome, int.Parse(idade), cpf, double.Parse(salario));
                else if (salario == string.Empty)
                    adicionarPessoa(nome, int.Parse(idade), cpf);
            }   
        }
        #endregion

        #region Filtrar ListView
        public static List<string> FiltrarListView(string parametroFiltro)
        {
            List<string> ListaFiltrada = new List<string>();
            List<Pessoas> ListaPessoasObjeto = new List<Pessoas>();
            string[] VetorInformacoes;
            foreach (var linha in Pessoas.ListaPessoasCSV)
            {
                VetorInformacoes = linha.Split(';');
                if (VetorInformacoes[3].Equals("Desempregado"))
                {
                    ListaPessoasObjeto.Add(new Pessoas(VetorInformacoes[0], int.Parse(VetorInformacoes[1]), VetorInformacoes[2]));
                }
                else if (!VetorInformacoes[3].Equals("Desempregado"))
                {
                    ListaPessoasObjeto.Add(new Funcionario(VetorInformacoes[0], int.Parse(VetorInformacoes[1]), VetorInformacoes[2], double.Parse(VetorInformacoes[3])));
                }
            }
            var retorno = ListaPessoasObjeto.Where(p => p.Nome.ToString().Contains(parametroFiltro)
                                                     || p.Idade.ToString().Contains(parametroFiltro)
                                                     || p.Cpf.ToString().Contains(parametroFiltro)
                                                     || $"{(p as Funcionario)?.Salario}".Contains(parametroFiltro));
            foreach (var linha in retorno)
            {
                ListaFiltrada.Add(linha.ToString());
            }
            return ListaFiltrada;
        }
        #endregion
    }
}
