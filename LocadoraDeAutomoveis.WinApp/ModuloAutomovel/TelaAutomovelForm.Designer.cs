namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    partial class TelaAutomovelForm
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            pickBoxFotoAutomovel = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtModelo = new TextBox();
            label3 = new Label();
            listGrupoDeAutomoveis = new ComboBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            txtCor = new TextBox();
            label6 = new Label();
            listTipoDeCombustivel = new ComboBox();
            label7 = new Label();
            nmrCapacidadeEmLitros = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            datePickerAnoDoCarro = new DateTimePicker();
            label10 = new Label();
            txtPlaca = new TextBox();
            nmrKmsRodados = new NumericUpDown();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pickBoxFotoAutomovel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrCapacidadeEmLitros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrKmsRodados).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(276, 540);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(361, 540);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 33);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pickBoxFotoAutomovel
            // 
            pickBoxFotoAutomovel.BorderStyle = BorderStyle.FixedSingle;
            pickBoxFotoAutomovel.Location = new Point(144, 12);
            pickBoxFotoAutomovel.Name = "pickBoxFotoAutomovel";
            pickBoxFotoAutomovel.Size = new Size(151, 121);
            pickBoxFotoAutomovel.SizeMode = PictureBoxSizeMode.StretchImage;
            pickBoxFotoAutomovel.TabIndex = 16;
            pickBoxFotoAutomovel.TabStop = false;
            pickBoxFotoAutomovel.Click += pickBoxFotoAutomovel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 73);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 17;
            label1.Text = "Foto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(144, 147);
            label2.Name = "label2";
            label2.Size = new Size(151, 13);
            label2.TabIndex = 18;
            label2.Text = "Clique para adicionar imagem";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(144, 216);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(279, 23);
            txtModelo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 219);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 20;
            label3.Text = "Modelo:";
            // 
            // listGrupoDeAutomoveis
            // 
            listGrupoDeAutomoveis.FormattingEnabled = true;
            listGrupoDeAutomoveis.Location = new Point(144, 181);
            listGrupoDeAutomoveis.Name = "listGrupoDeAutomoveis";
            listGrupoDeAutomoveis.Size = new Size(279, 23);
            listGrupoDeAutomoveis.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 22;
            label4.Text = "Grupo de Automoveis:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(144, 257);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(279, 23);
            txtMarca.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 260);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 24;
            label5.Text = "Marca:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(144, 294);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(279, 23);
            txtCor.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 297);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 26;
            label6.Text = "Cor:";
            // 
            // listTipoDeCombustivel
            // 
            listTipoDeCombustivel.FormattingEnabled = true;
            listTipoDeCombustivel.Location = new Point(144, 414);
            listTipoDeCombustivel.Name = "listTipoDeCombustivel";
            listTipoDeCombustivel.Size = new Size(139, 23);
            listTipoDeCombustivel.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 417);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 28;
            label7.Text = "Tipo de Combustivel:";
            // 
            // nmrCapacidadeEmLitros
            // 
            nmrCapacidadeEmLitros.Location = new Point(144, 453);
            nmrCapacidadeEmLitros.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrCapacidadeEmLitros.Name = "nmrCapacidadeEmLitros";
            nmrCapacidadeEmLitros.Size = new Size(139, 23);
            nmrCapacidadeEmLitros.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 455);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 30;
            label8.Text = "Capacidade em Litros:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(100, 379);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 31;
            label9.Text = "Placa:";
            // 
            // datePickerAnoDoCarro
            // 
            datePickerAnoDoCarro.CustomFormat = "yyyy";
            datePickerAnoDoCarro.Format = DateTimePickerFormat.Custom;
            datePickerAnoDoCarro.Location = new Point(144, 335);
            datePickerAnoDoCarro.Name = "datePickerAnoDoCarro";
            datePickerAnoDoCarro.Size = new Size(200, 23);
            datePickerAnoDoCarro.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(57, 341);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 34;
            label10.Text = "Ano do Carro:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(144, 376);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(200, 23);
            txtPlaca.TabIndex = 35;
            // 
            // nmrKmsRodados
            // 
            nmrKmsRodados.Location = new Point(144, 492);
            nmrKmsRodados.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrKmsRodados.Name = "nmrKmsRodados";
            nmrKmsRodados.Size = new Size(139, 23);
            nmrKmsRodados.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 494);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 37;
            label11.Text = "Km's Rodados:";
            // 
            // TelaAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 585);
            Controls.Add(label11);
            Controls.Add(nmrKmsRodados);
            Controls.Add(txtPlaca);
            Controls.Add(label10);
            Controls.Add(datePickerAnoDoCarro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(nmrCapacidadeEmLitros);
            Controls.Add(label7);
            Controls.Add(listTipoDeCombustivel);
            Controls.Add(label6);
            Controls.Add(txtCor);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(listGrupoDeAutomoveis);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pickBoxFotoAutomovel);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaAutomovelForm";
            Text = "Cadastrar Automovel";
            ((System.ComponentModel.ISupportInitialize)pickBoxFotoAutomovel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrCapacidadeEmLitros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrKmsRodados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private PictureBox pickBoxFotoAutomovel;
        private Label label1;
        private Label label2;
        private TextBox txtModelo;
        private Label label3;
        private ComboBox listGrupoDeAutomoveis;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtCor;
        private Label label6;
        private ComboBox listTipoDeCombustivel;
        private Label label7;
        private NumericUpDown nmrCapacidadeEmLitros;
        private Label label8;
        private Label label9;
        private DateTimePicker datePickerAnoDoCarro;
        private Label label10;
        private TextBox txtPlaca;
        private NumericUpDown nmrKmsRodados;
        private Label label11;
    }
}