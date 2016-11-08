using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasatroFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Idade;
            double Salario;
            if (CampoSalarioMasked.Text != string.Empty && CampCpfMasked.Text != string.Empty
                && CampoNome.Text != string.Empty && CampoIdadeMasked.Text != string.Empty)
            {
                if (int.TryParse(CampoIdadeMasked.Text, out Idade))
                    if (double.TryParse(CampoSalarioMasked.Text, out Salario))
                    {
                        Utilidades.adicionarFuncionario(CampoNome.Text, Idade, CampCpfMasked.Text, Salario);
                        ListViewForm1.Items.Add($"Nome: {CampoNome.Text} | Idade: {Idade} | Cpf: {CampCpfMasked.Text} | Salário: {Salario}");
                        MessageBox.Show("Funcionario cadastrado com sucesso !");
                        CampoIdadeMasked.ResetText();
                        CampoNome.ResetText();
                        CampoSalarioMasked.ResetText();
                        CampCpfMasked.ResetText();
                    }
                    else
                        MessageBox.Show("Erro ao Adicionar novo Funcionario");
            }
            if (CampoSalarioMasked.Text == string.Empty && CampCpfMasked.Text != string.Empty
               && CampoNome.Text != string.Empty && CampoIdadeMasked.Text != string.Empty)
            {
                if (int.TryParse(CampoIdadeMasked.Text, out Idade))
                {
                    Utilidades.adicionarPessoa(CampoNome.Text, Idade, CampCpfMasked.Text);
                    ListViewForm1.Items.Add($"Nome: {CampoNome.Text} | Idade: {Idade} | Cpf: {CampCpfMasked.Text} | Salário: Desempregado");
                    MessageBox.Show("Pessoa cadastrado com sucesso !");
                    CampoIdadeMasked.ResetText();
                    CampoNome.ResetText();
                    CampCpfMasked.ResetText();
                }
                else
                    MessageBox.Show("Erro ao Adicionar novo Funcionario");
            }

        }

        private void SalvarComo_Click(object sender, EventArgs e)
        {
            Utilidades.SalvarArquivos();
        }

        private void CarregarArquivos_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidades.CarregarArquivos();
                ListViewForm1.Items.Clear();
                foreach (var pessoa in Pessoas.ListaPessoas)
                    ListViewForm1.Items.Add(pessoa);
            }
            catch (FormatoDeArquivoInvalidoException)
            {
                MessageBox.Show("Formato de Arquivo Invalido","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FiltrarInformacoes(object sender, EventArgs e)
        {
            ListViewForm1.Clear();
            List<string> ListaFiltrada = Utilidades.FiltrarListView(FiltroInformacoes_Textbox.Text);
            foreach (var linha in ListaFiltrada)
                ListViewForm1.Items.Add(linha.ToString());
        }
    }
}
