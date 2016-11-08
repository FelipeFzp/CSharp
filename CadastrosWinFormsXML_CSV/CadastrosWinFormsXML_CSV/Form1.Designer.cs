namespace CasatroFuncionarios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.CampCpfMasked = new System.Windows.Forms.MaskedTextBox();
            this.CampoIdadeMasked = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdicionarButton_Click = new System.Windows.Forms.Button();
            this.CampoSalarioMasked = new System.Windows.Forms.MaskedTextBox();
            this.ListViewForm1 = new System.Windows.Forms.ListView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SalvarComo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CarregarArquivos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FiltroInformacoes_Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CampoNome
            // 
            this.CampoNome.Location = new System.Drawing.Point(24, 47);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(100, 20);
            this.CampoNome.TabIndex = 0;
            // 
            // CampCpfMasked
            // 
            this.CampCpfMasked.Location = new System.Drawing.Point(24, 146);
            this.CampCpfMasked.Mask = "000.000.000-00";
            this.CampCpfMasked.Name = "CampCpfMasked";
            this.CampCpfMasked.Size = new System.Drawing.Size(100, 20);
            this.CampCpfMasked.TabIndex = 2;
            // 
            // CampoIdadeMasked
            // 
            this.CampoIdadeMasked.Location = new System.Drawing.Point(24, 94);
            this.CampoIdadeMasked.Mask = "000";
            this.CampoIdadeMasked.Name = "CampoIdadeMasked";
            this.CampoIdadeMasked.Size = new System.Drawing.Size(100, 20);
            this.CampoIdadeMasked.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salário";
            // 
            // AdicionarButton_Click
            // 
            this.AdicionarButton_Click.Location = new System.Drawing.Point(174, 242);
            this.AdicionarButton_Click.Name = "AdicionarButton_Click";
            this.AdicionarButton_Click.Size = new System.Drawing.Size(75, 23);
            this.AdicionarButton_Click.TabIndex = 4;
            this.AdicionarButton_Click.Text = "Adicionar";
            this.AdicionarButton_Click.UseVisualStyleBackColor = true;
            this.AdicionarButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // CampoSalarioMasked
            // 
            this.CampoSalarioMasked.Location = new System.Drawing.Point(24, 203);
            this.CampoSalarioMasked.Mask = "00000";
            this.CampoSalarioMasked.Name = "CampoSalarioMasked";
            this.CampoSalarioMasked.Size = new System.Drawing.Size(100, 20);
            this.CampoSalarioMasked.TabIndex = 3;
            this.CampoSalarioMasked.ValidatingType = typeof(int);
            // 
            // ListViewForm1
            // 
            this.ListViewForm1.CheckBoxes = true;
            this.ListViewForm1.Location = new System.Drawing.Point(174, 49);
            this.ListViewForm1.Name = "ListViewForm1";
            this.ListViewForm1.Size = new System.Drawing.Size(387, 174);
            this.ListViewForm1.TabIndex = 10;
            this.ListViewForm1.UseCompatibleStateImageBehavior = false;
            this.ListViewForm1.View = System.Windows.Forms.View.List;
            // 
            // SalvarComo
            // 
            this.SalvarComo.Location = new System.Drawing.Point(477, 242);
            this.SalvarComo.Name = "SalvarComo";
            this.SalvarComo.Size = new System.Drawing.Size(84, 23);
            this.SalvarComo.TabIndex = 6;
            this.SalvarComo.Text = "Salvar Como...";
            this.SalvarComo.UseVisualStyleBackColor = true;
            this.SalvarComo.Click += new System.EventHandler(this.SalvarComo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "* Campos Obrigatórios";
            // 
            // CarregarArquivos
            // 
            this.CarregarArquivos.Location = new System.Drawing.Point(174, 18);
            this.CarregarArquivos.Name = "CarregarArquivos";
            this.CarregarArquivos.Size = new System.Drawing.Size(75, 23);
            this.CarregarArquivos.TabIndex = 15;
            this.CarregarArquivos.Text = "Carregar...";
            this.CarregarArquivos.UseVisualStyleBackColor = true;
            this.CarregarArquivos.Click += new System.EventHandler(this.CarregarArquivos_Click);
            // 
            // FiltroInformacoes_Textbox
            // 
            this.FiltroInformacoes_Textbox.Location = new System.Drawing.Point(461, 23);
            this.FiltroInformacoes_Textbox.Name = "FiltroInformacoes_Textbox";
            this.FiltroInformacoes_Textbox.Size = new System.Drawing.Size(100, 20);
            this.FiltroInformacoes_Textbox.TabIndex = 16;
            this.FiltroInformacoes_Textbox.TextChanged += new System.EventHandler(this.FiltrarInformacoes);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Filtrar por:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 277);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FiltroInformacoes_Textbox);
            this.Controls.Add(this.CarregarArquivos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalvarComo);
            this.Controls.Add(this.ListViewForm1);
            this.Controls.Add(this.CampoSalarioMasked);
            this.Controls.Add(this.AdicionarButton_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampoIdadeMasked);
            this.Controls.Add(this.CampCpfMasked);
            this.Controls.Add(this.CampoNome);
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.MaskedTextBox CampCpfMasked;
        private System.Windows.Forms.MaskedTextBox CampoIdadeMasked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AdicionarButton_Click;
        private System.Windows.Forms.MaskedTextBox CampoSalarioMasked;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SalvarComo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListView ListViewForm1;
        private System.Windows.Forms.Button CarregarArquivos;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FiltroInformacoes_Textbox;
        private System.Windows.Forms.Label label9;
    }
}

