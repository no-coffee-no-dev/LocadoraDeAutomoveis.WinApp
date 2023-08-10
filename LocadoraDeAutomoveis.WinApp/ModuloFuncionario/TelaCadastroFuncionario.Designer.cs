namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    partial class TelaCadastroFuncionario
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
            txtNomeFuncionario = new TextBox();
            dTPAdmissao = new DateTimePicker();
            btnGravar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            txtSalario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtSalario).BeginInit();
            SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(95, 39);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(271, 23);
            txtNomeFuncionario.TabIndex = 0;
            // 
            // dTPAdmissao
            // 
            dTPAdmissao.Location = new Point(95, 72);
            dTPAdmissao.Name = "dTPAdmissao";
            dTPAdmissao.Size = new Size(126, 23);
            dTPAdmissao.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(188, 176);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 39);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Salvar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Admissão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 107);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Salário";
            // 
            // button2
            // 
            button2.Location = new Point(280, 176);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(86, 39);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(95, 105);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(120, 23);
            txtSalario.TabIndex = 8;
            // 
            // TelaCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 237);
            Controls.Add(txtSalario);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(dTPAdmissao);
            Controls.Add(txtNomeFuncionario);
            Name = "TelaCadastroFuncionario";
            Text = "Funcionário";
            ((System.ComponentModel.ISupportInitialize)txtSalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeFuncionario;
        private DateTimePicker dTPAdmissao;
        private Button btnGravar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private NumericUpDown txtSalario;
    }
}