namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    partial class TelaFiltroGrupoDeAutomoveis
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
            tabelaGrupoDeAutomoveis = new ModuloGrupoDoAutomovel.TabelaGrupoDeAutomoveisControl();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // tabelaGrupoDeAutomoveis
            // 
            tabelaGrupoDeAutomoveis.Location = new Point(-1, -2);
            tabelaGrupoDeAutomoveis.Name = "tabelaGrupoDeAutomoveis";
            tabelaGrupoDeAutomoveis.Size = new Size(533, 366);
            tabelaGrupoDeAutomoveis.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(356, 370);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 33);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Selecionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(441, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 33);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroGrupoDeAutomoveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 410);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabelaGrupoDeAutomoveis);
            Name = "TelaFiltroGrupoDeAutomoveis";
            Text = "Grupo Do Automovel para FIltrar";
            ResumeLayout(false);
        }

        #endregion

        private ModuloGrupoDoAutomovel.TabelaGrupoDeAutomoveisControl tabelaGrupoDeAutomoveis;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}