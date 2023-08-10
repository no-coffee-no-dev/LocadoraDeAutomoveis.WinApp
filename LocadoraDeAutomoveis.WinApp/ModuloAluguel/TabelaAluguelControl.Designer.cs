namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    partial class TabelaAluguelControl
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
            tabelaAluguel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaAluguel).BeginInit();
            SuspendLayout();
            // 
            // tabelaAluguel
            // 
            tabelaAluguel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaAluguel.Location = new Point(0, 0);
            tabelaAluguel.Name = "tabelaAluguel";
            tabelaAluguel.RowTemplate.Height = 25;
            tabelaAluguel.Size = new Size(537, 372);
            tabelaAluguel.TabIndex = 0;
            // 
            // TabelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaAluguel);
            Name = "TabelaAluguelControl";
            Size = new Size(537, 372);
            ((System.ComponentModel.ISupportInitialize)tabelaAluguel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaAluguel;
    }
}
