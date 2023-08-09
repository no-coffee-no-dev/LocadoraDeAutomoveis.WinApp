namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    partial class TabelaTaxaServicoControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaTaxaServicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaTaxaServicos).BeginInit();
            SuspendLayout();
            // 
            // tabelaTaxaServicos
            // 
            tabelaTaxaServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTaxaServicos.Location = new Point(0, 0);
            tabelaTaxaServicos.Name = "tabelaTaxaServicos";
            tabelaTaxaServicos.RowHeadersWidth = 51;
            tabelaTaxaServicos.RowTemplate.Height = 29;
            tabelaTaxaServicos.Size = new Size(440, 291);
            tabelaTaxaServicos.TabIndex = 0;
            // 
            // TabelaTaxaServicoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaTaxaServicos);
            Name = "TabelaTaxaServicoControl";
            Size = new Size(440, 291);
            ((System.ComponentModel.ISupportInitialize)tabelaTaxaServicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaTaxaServicos;
    }
}
