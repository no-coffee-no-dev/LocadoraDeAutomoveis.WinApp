namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    partial class TabelaPlanoDeCobrancaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaPlanoDeCobranca = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaPlanoDeCobranca).BeginInit();
            SuspendLayout();
            // 
            // tabelaPlanoDeCobranca
            // 
            tabelaPlanoDeCobranca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaPlanoDeCobranca.Location = new Point(0, 0);
            tabelaPlanoDeCobranca.Name = "tabelaPlanoDeCobranca";
            tabelaPlanoDeCobranca.RowTemplate.Height = 25;
            tabelaPlanoDeCobranca.Size = new Size(469, 281);
            tabelaPlanoDeCobranca.TabIndex = 0;
            // 
            // TabelaPlanoDeCobrancaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaPlanoDeCobranca);
            Name = "TabelaPlanoDeCobrancaControl";
            Size = new Size(469, 281);
            ((System.ComponentModel.ISupportInitialize)tabelaPlanoDeCobranca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaPlanoDeCobranca;
    }
}
