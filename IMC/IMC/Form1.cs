using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            button1.Enabled = false;
            richTextBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Feminino"))
            {
                label6.Text = "Ok!";
                label6.ForeColor = System.Drawing.Color.Green;
                Informations.Genrer = comboBox1.SelectedItem.ToString();
                button1_Click(sender, e);
            }
            else
            {
                if (comboBox1.SelectedItem.ToString().Equals("Masculino"))
                {
                    label6.Text = "Ok!";
                    label6.ForeColor = System.Drawing.Color.Green;
                    Informations.Genrer = comboBox1.SelectedItem.ToString();
                    button1_Click(sender, e);
                }
                else
                {
                    label6.ForeColor = System.Drawing.Color.Red;
                    label6.Text = "Defina o seu gênero";
                    button1.Enabled = false;
                    button1_Click(sender, e);
                }
            }
               

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           decimal valueWeight;
            if (!textBox1.Text.Equals(string.Empty) && decimal.TryParse(textBox1.Text, out valueWeight))
            {
                label4.Text = "Ok!";
                label4.ForeColor = System.Drawing.Color.Green;
                Informations.Weight = valueWeight;
                button1_Click(sender, e);
            }
            else
            {
                label4.Text = "X";
                label4.ForeColor = System.Drawing.Color.Red;
                button1.Enabled = false;
                button1_Click(sender, e);
            }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            decimal valueHeight;
            if (!textBox2.Text.Equals(string.Empty) && decimal.TryParse(textBox2.Text, out valueHeight))
            {
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "Ok!";
                Informations.Height = valueHeight;
                button1_Click(sender, e);
            }
            else
            {
                label5.Text = "X";
                label5.ForeColor = System.Drawing.Color.Red;
                button1.Enabled = false;
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Informations.Genrer != null && label5.Text.Equals("Ok!") && label4.Text.Equals("Ok!"))
            {
                button1.Enabled = true;
                if (button1.Capture)
                {
                    richTextBox1.Text = Informations.ImcCalculate();
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
