namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    partial class TabelaCondutorControl
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
            tabelaCondutor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaCondutor).BeginInit();
            SuspendLayout();
            // 
            // tabelaCondutor
            // 
            tabelaCondutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCondutor.Location = new Point(3, 3);
            tabelaCondutor.Name = "tabelaCondutor";
            tabelaCondutor.RowTemplate.Height = 25;
            tabelaCondutor.Size = new Size(127, 144);
            tabelaCondutor.TabIndex = 0;
            // 
            // TabelaCondutorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaCondutor);
            Name = "TabelaCondutorControl";
            ((System.ComponentModel.ISupportInitialize)tabelaCondutor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaCondutor;
    }
}
