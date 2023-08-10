namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    partial class TelaCondutorForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_CPFCondutor = new TextBox();
            txt_NomeCondutor = new TextBox();
            txt_EmailCondutor = new TextBox();
            txt_TelefoneCondutor = new TextBox();
            txt_CNHCondutor = new TextBox();
            cb_Cliente = new CheckBox();
            dtp_ValidadeCNHCondutor = new DateTimePicker();
            btn_salvar = new Button();
            button2 = new Button();
            cbx_cliente = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 106);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 149);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 199);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 194);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 247);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "CNH:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 304);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Validade:";
            // 
            // txt_CPFCondutor
            // 
            txt_CPFCondutor.Location = new Point(244, 191);
            txt_CPFCondutor.Name = "txt_CPFCondutor";
            txt_CPFCondutor.Size = new Size(100, 23);
            txt_CPFCondutor.TabIndex = 8;
            // 
            // txt_NomeCondutor
            // 
            txt_NomeCondutor.Location = new Point(68, 103);
            txt_NomeCondutor.Name = "txt_NomeCondutor";
            txt_NomeCondutor.Size = new Size(276, 23);
            txt_NomeCondutor.TabIndex = 9;
            // 
            // txt_EmailCondutor
            // 
            txt_EmailCondutor.Location = new Point(68, 146);
            txt_EmailCondutor.Name = "txt_EmailCondutor";
            txt_EmailCondutor.Size = new Size(276, 23);
            txt_EmailCondutor.TabIndex = 10;
            // 
            // txt_TelefoneCondutor
            // 
            txt_TelefoneCondutor.Location = new Point(68, 191);
            txt_TelefoneCondutor.Name = "txt_TelefoneCondutor";
            txt_TelefoneCondutor.Size = new Size(134, 23);
            txt_TelefoneCondutor.TabIndex = 11;
            // 
            // txt_CNHCondutor
            // 
            txt_CNHCondutor.Location = new Point(68, 239);
            txt_CNHCondutor.Name = "txt_CNHCondutor";
            txt_CNHCondutor.Size = new Size(134, 23);
            txt_CNHCondutor.TabIndex = 13;
            // 
            // cb_Cliente
            // 
            cb_Cliente.AutoSize = true;
            cb_Cliente.Location = new Point(78, 62);
            cb_Cliente.Name = "cb_Cliente";
            cb_Cliente.Size = new Size(124, 19);
            cb_Cliente.TabIndex = 15;
            cb_Cliente.Text = "Cliente é condutor";
            cb_Cliente.UseVisualStyleBackColor = true;
            cb_Cliente.CheckedChanged += cb_Cliente_CheckedChanged;
            // 
            // dtp_ValidadeCNHCondutor
            // 
            dtp_ValidadeCNHCondutor.Format = DateTimePickerFormat.Short;
            dtp_ValidadeCNHCondutor.Location = new Point(72, 298);
            dtp_ValidadeCNHCondutor.Name = "dtp_ValidadeCNHCondutor";
            dtp_ValidadeCNHCondutor.Size = new Size(130, 23);
            dtp_ValidadeCNHCondutor.TabIndex = 16;
            // 
            // btn_salvar
            // 
            btn_salvar.DialogResult = DialogResult.OK;
            btn_salvar.Location = new Point(175, 360);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 17;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(256, 360);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbx_cliente
            // 
            cbx_cliente.FormattingEnabled = true;
            cbx_cliente.Location = new Point(72, 33);
            cbx_cliente.Name = "cbx_cliente";
            cbx_cliente.Size = new Size(272, 23);
            cbx_cliente.TabIndex = 14;
            // 
            // TelaCondutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 389);
            Controls.Add(button2);
            Controls.Add(btn_salvar);
            Controls.Add(dtp_ValidadeCNHCondutor);
            Controls.Add(cb_Cliente);
            Controls.Add(cbx_cliente);
            Controls.Add(txt_CNHCondutor);
            Controls.Add(txt_TelefoneCondutor);
            Controls.Add(txt_EmailCondutor);
            Controls.Add(txt_NomeCondutor);
            Controls.Add(txt_CPFCondutor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "TelaCondutorForm";
            Text = "Cadastro de Condutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_CPFCondutor;
        private TextBox txt_NomeCondutor;
        private TextBox txt_EmailCondutor;
        private TextBox txt_TelefoneCondutor;
        private TextBox txt_CNHCondutor;
        private CheckBox cb_Cliente;
        private DateTimePicker dtp_ValidadeCNHCondutor;
        private Button btn_salvar;
        private Button button2;
        private ComboBox cbx_cliente;
    }
}