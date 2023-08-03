namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{
    partial class TelaCupomForm
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            nmrValor = new NumericUpDown();
            dtpickerValidade = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            listParceiro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrValor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(85, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(279, 23);
            txtNome.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 67);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor:";
            // 
            // nmrValor
            // 
            nmrValor.Location = new Point(85, 65);
            nmrValor.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrValor.Name = "nmrValor";
            nmrValor.Size = new Size(120, 23);
            nmrValor.TabIndex = 8;
            // 
            // dtpickerValidade
            // 
            dtpickerValidade.Format = DateTimePickerFormat.Short;
            dtpickerValidade.Location = new Point(85, 100);
            dtpickerValidade.Name = "dtpickerValidade";
            dtpickerValidade.Size = new Size(148, 23);
            dtpickerValidade.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 106);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Validade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 139);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 12;
            label4.Text = "Parceiro:";
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(199, 178);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(284, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 33);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listParceiro
            // 
            listParceiro.FormattingEnabled = true;
            listParceiro.Location = new Point(84, 136);
            listParceiro.Name = "listParceiro";
            listParceiro.Size = new Size(149, 23);
            listParceiro.TabIndex = 15;
            // 
            // TelaCupomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 221);
            Controls.Add(listParceiro);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpickerValidade);
            Controls.Add(nmrValor);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "TelaCupomForm";
            Text = "Cadastrar Cupom";
            ((System.ComponentModel.ISupportInitialize)nmrValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private NumericUpDown nmrValor;
        private DateTimePicker dtpickerValidade;
        private Label label3;
        private Label label4;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox listParceiro;
    }
}