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
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(35, 56);
            Nome.Name = "Nome";
            Nome.Size = new Size(57, 20);
            Nome.TabIndex = 0;
            Nome.Text = "Nome: ";
            // 
            // Preco
            // 
            Preco.AutoSize = true;
            Preco.Location = new Point(35, 114);
            Preco.Name = "Preco";
            Preco.Size = new Size(49, 20);
            Preco.TabIndex = 1;
            Preco.Text = "Preço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(409, 27);
            txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(98, 111);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(162, 27);
            txtPreco.TabIndex = 3;
            // 
            // rdbPrecoFixo
            // 
            rdbPrecoFixo.AutoSize = true;
            rdbPrecoFixo.Location = new Point(44, 37);
            rdbPrecoFixo.Name = "rdbPrecoFixo";
            rdbPrecoFixo.Size = new Size(98, 24);
            rdbPrecoFixo.TabIndex = 4;
            rdbPrecoFixo.TabStop = true;
            rdbPrecoFixo.Text = "Preço Fixo";
            rdbPrecoFixo.UseVisualStyleBackColor = true;
            // 
            // rdbCobrancaDiaria
            // 
            rdbCobrancaDiaria.AutoSize = true;
            rdbCobrancaDiaria.Location = new Point(212, 37);
            rdbCobrancaDiaria.Name = "rdbCobrancaDiaria";
            rdbCobrancaDiaria.Size = new Size(137, 24);
            rdbCobrancaDiaria.TabIndex = 5;
            rdbCobrancaDiaria.TabStop = true;
            rdbCobrancaDiaria.Text = "Cobrança Diária";
            rdbCobrancaDiaria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPrecoFixo);
            groupBox1.Controls.Add(rdbCobrancaDiaria);
            groupBox1.Location = new Point(28, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 85);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plano de Cálculo";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(276, 288);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 59);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(405, 288);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 59);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTaxaServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 372);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(Preco);
            Controls.Add(Nome);
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
        private Button btnGravar;
        private Button btnCancelar;
    }
}