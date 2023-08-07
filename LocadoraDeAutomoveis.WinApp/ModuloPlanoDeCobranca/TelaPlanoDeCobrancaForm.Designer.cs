namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    partial class TelaPlanoDeCobrancaForm
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
            listGrupoDeAutomoveis = new ComboBox();
            listTipoDePlano = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            nmrKmDisponiveis = new NumericUpDown();
            nmrPrecoPorKM = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            nmrPrecoDiaria = new NumericUpDown();
            label1 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrKmDisponiveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecoPorKM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecoDiaria).BeginInit();
            SuspendLayout();
            // 
            // listGrupoDeAutomoveis
            // 
            listGrupoDeAutomoveis.FormattingEnabled = true;
            listGrupoDeAutomoveis.Location = new Point(145, 20);
            listGrupoDeAutomoveis.Name = "listGrupoDeAutomoveis";
            listGrupoDeAutomoveis.Size = new Size(263, 23);
            listGrupoDeAutomoveis.TabIndex = 16;
            // 
            // listTipoDePlano
            // 
            listTipoDePlano.FormattingEnabled = true;
            listTipoDePlano.Location = new Point(190, 32);
            listTipoDePlano.Name = "listTipoDePlano";
            listTipoDePlano.Size = new Size(149, 23);
            listTipoDePlano.TabIndex = 17;
            listTipoDePlano.SelectedIndexChanged += listTipoDePlano_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 18;
            label4.Text = "Grupo de Automoveis:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nmrKmDisponiveis);
            groupBox1.Controls.Add(nmrPrecoPorKM);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nmrPrecoDiaria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listTipoDePlano);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 192);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuracao de Planos";
            // 
            // nmrKmDisponiveis
            // 
            nmrKmDisponiveis.Location = new Point(190, 142);
            nmrKmDisponiveis.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrKmDisponiveis.Name = "nmrKmDisponiveis";
            nmrKmDisponiveis.Size = new Size(149, 23);
            nmrKmDisponiveis.TabIndex = 25;
            nmrKmDisponiveis.UpDownAlign = LeftRightAlignment.Left;
            // 
            // nmrPrecoPorKM
            // 
            nmrPrecoPorKM.Location = new Point(190, 107);
            nmrPrecoPorKM.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrPrecoPorKM.Name = "nmrPrecoPorKM";
            nmrPrecoPorKM.Size = new Size(149, 23);
            nmrPrecoPorKM.TabIndex = 24;
            nmrPrecoPorKM.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 144);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 23;
            label5.Text = "Km Disponiveis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 109);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 22;
            label3.Text = "Preco Por KM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 21;
            label2.Text = "Preco Diaria:";
            // 
            // nmrPrecoDiaria
            // 
            nmrPrecoDiaria.Location = new Point(190, 70);
            nmrPrecoDiaria.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrPrecoDiaria.Name = "nmrPrecoDiaria";
            nmrPrecoDiaria.Size = new Size(149, 23);
            nmrPrecoDiaria.TabIndex = 20;
            nmrPrecoDiaria.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 19;
            label1.Text = "Tipo do Plano:";
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(243, 257);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(328, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 33);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaPlanoDeCobrancaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 308);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(listGrupoDeAutomoveis);
            Name = "TelaPlanoDeCobrancaForm";
            Text = "Cadastrar Plano De Cobranca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrKmDisponiveis).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecoPorKM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecoDiaria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listGrupoDeAutomoveis;
        private ComboBox listTipoDePlano;
        private Label label4;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown nmrKmDisponiveis;
        private NumericUpDown nmrPrecoPorKM;
        private Label label5;
        private Label label3;
        private Label label2;
        private NumericUpDown nmrPrecoDiaria;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}