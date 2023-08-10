namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{
    partial class TabelaCuponsControl
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
            tabelaCupons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaCupons).BeginInit();
            SuspendLayout();
            // 
            // tabelaCupons
            // 
            tabelaCupons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCupons.Location = new Point(1, 2);
            tabelaCupons.Name = "tabelaCupons";
            tabelaCupons.RowTemplate.Height = 25;
            tabelaCupons.Size = new Size(429, 273);
            tabelaCupons.TabIndex = 0;
            // 
            // TabelaCuponsCotrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaCupons);
            Name = "TabelaCuponsCotrol";
            Size = new Size(433, 278);
            ((System.ComponentModel.ISupportInitialize)tabelaCupons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaCupons;
    }
}
