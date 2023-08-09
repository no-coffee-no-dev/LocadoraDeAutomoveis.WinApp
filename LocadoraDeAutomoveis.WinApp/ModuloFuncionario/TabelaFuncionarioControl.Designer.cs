namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    partial class TabelaFuncionarioControl
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
            tabelaFuncionario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).BeginInit();
            SuspendLayout();
            // 
            // tabelaFuncionario
            // 
            tabelaFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFuncionario.Location = new Point(18, 31);
            tabelaFuncionario.Name = "tabelaFuncionario";
            tabelaFuncionario.RowTemplate.Height = 25;
            tabelaFuncionario.Size = new Size(240, 150);
            tabelaFuncionario.TabIndex = 0;
            // 
            // TabelaFuncionarioControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaFuncionario);
            Name = "TabelaFuncionarioControl";
            Size = new Size(272, 214);
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaFuncionario;
    }
}
