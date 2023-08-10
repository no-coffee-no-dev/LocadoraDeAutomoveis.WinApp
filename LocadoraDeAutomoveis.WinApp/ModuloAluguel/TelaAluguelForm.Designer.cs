namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            label4 = new Label();
            listCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            listFuncionario = new ComboBox();
            label3 = new Label();
            listPlanoDeCobranca = new ComboBox();
            label5 = new Label();
            listCondutor = new ComboBox();
            label6 = new Label();
            listAutomovel = new ComboBox();
            label7 = new Label();
            txtKmDoAutomovel = new TextBox();
            datePickerDataDoAluguel = new DateTimePicker();
            datePickerDataDaDevolucao = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtBuscarCupom = new TextBox();
            btnAplicarCupom = new Button();
            listaTaxasEServicos = new CheckedListBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label11 = new Label();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // listGrupoDeAutomoveis
            // 
            listGrupoDeAutomoveis.FormattingEnabled = true;
            listGrupoDeAutomoveis.Location = new Point(144, 151);
            listGrupoDeAutomoveis.Name = "listGrupoDeAutomoveis";
            listGrupoDeAutomoveis.Size = new Size(185, 23);
            listGrupoDeAutomoveis.TabIndex = 22;
            listGrupoDeAutomoveis.SelectedIndexChanged += listGrupoDeAutomoveis_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 23;
            label4.Text = "Grupo de Automoveis:";
            // 
            // listCliente
            // 
            listCliente.FormattingEnabled = true;
            listCliente.Location = new Point(144, 106);
            listCliente.Name = "listCliente";
            listCliente.Size = new Size(185, 23);
            listCliente.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 109);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 25;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 26;
            label2.Text = "Funcionario:";
            // 
            // listFuncionario
            // 
            listFuncionario.FormattingEnabled = true;
            listFuncionario.Location = new Point(144, 55);
            listFuncionario.Name = "listFuncionario";
            listFuncionario.Size = new Size(185, 23);
            listFuncionario.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 196);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 28;
            label3.Text = "Plano de Cobranca:";
            // 
            // listPlanoDeCobranca
            // 
            listPlanoDeCobranca.FormattingEnabled = true;
            listPlanoDeCobranca.Location = new Point(144, 193);
            listPlanoDeCobranca.Name = "listPlanoDeCobranca";
            listPlanoDeCobranca.Size = new Size(185, 23);
            listPlanoDeCobranca.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 106);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 30;
            label5.Text = "Condutor:";
            // 
            // listCondutor
            // 
            listCondutor.FormattingEnabled = true;
            listCondutor.Location = new Point(464, 103);
            listCondutor.Name = "listCondutor";
            listCondutor.Size = new Size(185, 23);
            listCondutor.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 154);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 32;
            label6.Text = "Automovel:";
            // 
            // listAutomovel
            // 
            listAutomovel.FormattingEnabled = true;
            listAutomovel.Location = new Point(464, 151);
            listAutomovel.Name = "listAutomovel";
            listAutomovel.Size = new Size(185, 23);
            listAutomovel.TabIndex = 33;
            listAutomovel.SelectedIndexChanged += listAutomovel_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 196);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 34;
            label7.Text = "KM do Automovel:";
            // 
            // txtKmDoAutomovel
            // 
            txtKmDoAutomovel.Location = new Point(464, 193);
            txtKmDoAutomovel.Name = "txtKmDoAutomovel";
            txtKmDoAutomovel.ReadOnly = true;
            txtKmDoAutomovel.Size = new Size(185, 23);
            txtKmDoAutomovel.TabIndex = 35;
            // 
            // datePickerDataDoAluguel
            // 
            datePickerDataDoAluguel.CustomFormat = "yyyy";
            datePickerDataDoAluguel.Format = DateTimePickerFormat.Short;
            datePickerDataDoAluguel.Location = new Point(144, 234);
            datePickerDataDoAluguel.Name = "datePickerDataDoAluguel";
            datePickerDataDoAluguel.Size = new Size(185, 23);
            datePickerDataDoAluguel.TabIndex = 36;
            // 
            // datePickerDataDaDevolucao
            // 
            datePickerDataDaDevolucao.CustomFormat = "yyyy";
            datePickerDataDaDevolucao.Format = DateTimePickerFormat.Short;
            datePickerDataDaDevolucao.Location = new Point(464, 234);
            datePickerDataDaDevolucao.Name = "datePickerDataDaDevolucao";
            datePickerDataDaDevolucao.Size = new Size(185, 23);
            datePickerDataDaDevolucao.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 240);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 38;
            label8.Text = "Data do Aluguel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(345, 240);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 39;
            label9.Text = "Devolucao Previstal:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 284);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 40;
            label10.Text = "Cupom:";
            // 
            // txtBuscarCupom
            // 
            txtBuscarCupom.Location = new Point(144, 281);
            txtBuscarCupom.Name = "txtBuscarCupom";
            txtBuscarCupom.Size = new Size(122, 23);
            txtBuscarCupom.TabIndex = 41;
            // 
            // btnAplicarCupom
            // 
            btnAplicarCupom.Location = new Point(272, 276);
            btnAplicarCupom.Name = "btnAplicarCupom";
            btnAplicarCupom.Size = new Size(112, 31);
            btnAplicarCupom.TabIndex = 42;
            btnAplicarCupom.Text = "Aplicar Cupom";
            btnAplicarCupom.UseVisualStyleBackColor = true;
            btnAplicarCupom.Click += btnAplicarCupom_Click;
            // 
            // listaTaxasEServicos
            // 
            listaTaxasEServicos.Dock = DockStyle.Fill;
            listaTaxasEServicos.FormattingEnabled = true;
            listaTaxasEServicos.Location = new Point(3, 3);
            listaTaxasEServicos.Name = "listaTaxasEServicos";
            listaTaxasEServicos.Size = new Size(628, 198);
            listaTaxasEServicos.TabIndex = 43;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(28, 313);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(642, 232);
            tabControl1.TabIndex = 44;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listaTaxasEServicos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(634, 204);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Taxas E Servicos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(506, 577);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(591, 577);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 33);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 586);
            label11.Name = "label11";
            label11.Size = new Size(109, 15);
            label11.TabIndex = 47;
            label11.Text = "Valor Total Previsto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(150, 586);
            label12.Name = "label12";
            label12.Size = new Size(23, 15);
            label12.TabIndex = 48;
            label12.Text = "R$:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 622);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabControl1);
            Controls.Add(btnAplicarCupom);
            Controls.Add(txtBuscarCupom);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(datePickerDataDaDevolucao);
            Controls.Add(datePickerDataDoAluguel);
            Controls.Add(txtKmDoAutomovel);
            Controls.Add(label7);
            Controls.Add(listAutomovel);
            Controls.Add(label6);
            Controls.Add(listCondutor);
            Controls.Add(label5);
            Controls.Add(listPlanoDeCobranca);
            Controls.Add(label3);
            Controls.Add(listFuncionario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listCliente);
            Controls.Add(label4);
            Controls.Add(listGrupoDeAutomoveis);
            Name = "TelaAluguelForm";
            Text = "Cadastrar Aluguel";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listGrupoDeAutomoveis;
        private Label label4;
        private ComboBox listCliente;
        private Label label1;
        private Label label2;
        private ComboBox listFuncionario;
        private Label label3;
        private ComboBox listPlanoDeCobranca;
        private Label label5;
        private ComboBox listCondutor;
        private Label label6;
        private ComboBox listAutomovel;
        private Label label7;
        private TextBox txtKmDoAutomovel;
        private DateTimePicker datePickerDataDoAluguel;
        private DateTimePicker datePickerDataDaDevolucao;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtBuscarCupom;
        private Button btnAplicarCupom;
        private CheckedListBox listaTaxasEServicos;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label11;
        private Label label12;
    }
}