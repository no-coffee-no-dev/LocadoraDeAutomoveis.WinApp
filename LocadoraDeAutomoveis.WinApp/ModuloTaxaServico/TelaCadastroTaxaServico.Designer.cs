namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    partial class TelaCadastroTaxaServico
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
            Nome = new Label();
            Preco = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            rdbPrecoFixo = new RadioButton();
            rdbCobrancaDiaria = new RadioButton();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(31, 42);
            Nome.Name = "Nome";
            Nome.Size = new Size(46, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome: ";
            // 
            // Preco
            // 
            Preco.AutoSize = true;
            Preco.Location = new Point(31, 86);
            Preco.Name = "Preco";
            Preco.Size = new Size(40, 15);
            Preco.TabIndex = 1;
            Preco.Text = "Preço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 42);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 23);
            txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(86, 83);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(142, 23);
            txtPreco.TabIndex = 3;
            // 
            // rdbPrecoFixo
            // 
            rdbPrecoFixo.AutoSize = true;
            rdbPrecoFixo.Location = new Point(38, 28);
            rdbPrecoFixo.Margin = new Padding(3, 2, 3, 2);
            rdbPrecoFixo.Name = "rdbPrecoFixo";
            rdbPrecoFixo.Size = new Size(80, 19);
            rdbPrecoFixo.TabIndex = 4;
            rdbPrecoFixo.TabStop = true;
            rdbPrecoFixo.Text = "Preço Fixo";
            rdbPrecoFixo.UseVisualStyleBackColor = true;
            // 
            // rdbCobrancaDiaria
            // 
            rdbCobrancaDiaria.AutoSize = true;
            rdbCobrancaDiaria.Location = new Point(186, 28);
            rdbCobrancaDiaria.Margin = new Padding(3, 2, 3, 2);
            rdbCobrancaDiaria.Name = "rdbCobrancaDiaria";
            rdbCobrancaDiaria.Size = new Size(109, 19);
            rdbCobrancaDiaria.TabIndex = 5;
            rdbCobrancaDiaria.TabStop = true;
            rdbCobrancaDiaria.Text = "Cobrança Diária";
            rdbCobrancaDiaria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPrecoFixo);
            groupBox1.Controls.Add(rdbCobrancaDiaria);
            groupBox1.Location = new Point(24, 128);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(419, 64);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plano de Cálculo";
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(297, 234);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 46;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(382, 234);
            button1.Name = "button1";
            button1.Size = new Size(79, 33);
            button1.TabIndex = 47;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTaxaServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 279);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(Preco);
            Controls.Add(Nome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroTaxaServico";
            Text = "Cadastro de Taxa ou Serviço";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Preco;
        private TextBox txtNome;
        private TextBox txtPreco;
        private RadioButton rdbPrecoFixo;
        private RadioButton rdbCobrancaDiaria;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private Button button1;
    }
}