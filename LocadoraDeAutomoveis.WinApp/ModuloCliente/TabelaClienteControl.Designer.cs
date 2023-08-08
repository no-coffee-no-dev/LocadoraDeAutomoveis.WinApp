namespace LocadoraDeAutomoveis.WinApp.ModuloCliente
{
    partial class TabelaCliente
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
            tabelaClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).BeginInit();
            SuspendLayout();
            // 
            // tabelaClientes
            // 
            tabelaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientes.Location = new Point(0, 0);
            tabelaClientes.Margin = new Padding(3, 4, 3, 4);
            tabelaClientes.Name = "tabelaClientes";
            tabelaClientes.RowHeadersWidth = 51;
            tabelaClientes.RowTemplate.Height = 25;
            tabelaClientes.Size = new Size(490, 364);
            tabelaClientes.TabIndex = 1;
            // 
            // TabelaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaClientes);
            Name = "TabelaCliente";
            Size = new Size(491, 364);
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaClientes;
    }
}
