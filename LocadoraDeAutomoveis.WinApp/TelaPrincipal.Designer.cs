namespace LocadoraDeAutomoveis.WinApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            parceirosToolStripMenuItem = new ToolStripMenuItem();
            cupomToolStripMenuItem = new ToolStripMenuItem();
            grupoDeAutomoveisToolStripMenuItem = new ToolStripMenuItem();
            planoDeCobrancaToolStripMenuItem = new ToolStripMenuItem();
            toolStripBarraDeTarefas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            StatusRodape = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            painelPrincipal = new Panel();
            label1 = new Label();
            lblTipoCadastro = new Label();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripBarraDeTarefas.SuspendLayout();
            StatusRodape.SuspendLayout();
            painelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(125, 353);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parceirosToolStripMenuItem, cupomToolStripMenuItem, grupoDeAutomoveisToolStripMenuItem, planoDeCobrancaToolStripMenuItem, clienteToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(114, 19);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // parceirosToolStripMenuItem
            // 
            parceirosToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            parceirosToolStripMenuItem.Size = new Size(191, 22);
            parceirosToolStripMenuItem.Text = "Parceiros";
            parceirosToolStripMenuItem.Click += parceirosToolStripMenuItem_Click;
            // 
            // cupomToolStripMenuItem
            // 
            cupomToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            cupomToolStripMenuItem.Name = "cupomToolStripMenuItem";
            cupomToolStripMenuItem.Size = new Size(191, 22);
            cupomToolStripMenuItem.Text = "Cupom";
            cupomToolStripMenuItem.Click += cupomToolStripMenuItem_Click;
            // 
            // grupoDeAutomoveisToolStripMenuItem
            // 
            grupoDeAutomoveisToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            grupoDeAutomoveisToolStripMenuItem.Name = "grupoDeAutomoveisToolStripMenuItem";
            grupoDeAutomoveisToolStripMenuItem.Size = new Size(191, 22);
            grupoDeAutomoveisToolStripMenuItem.Text = "Grupo De Automoveis";
            grupoDeAutomoveisToolStripMenuItem.Click += grupoDeAutomoveisToolStripMenuItem_Click;
            // 
            // planoDeCobrancaToolStripMenuItem
            // 
            planoDeCobrancaToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            planoDeCobrancaToolStripMenuItem.Name = "planoDeCobrancaToolStripMenuItem";
            planoDeCobrancaToolStripMenuItem.Size = new Size(191, 22);
            planoDeCobrancaToolStripMenuItem.Text = "Plano De Cobranca";
            planoDeCobrancaToolStripMenuItem.Click += planoDeCobrancaToolStripMenuItem_Click;
            // 
            // toolStripBarraDeTarefas
            // 
            toolStripBarraDeTarefas.Dock = DockStyle.Left;
            toolStripBarraDeTarefas.GripStyle = ToolStripGripStyle.Hidden;
            toolStripBarraDeTarefas.ImageScalingSize = new Size(20, 20);
            toolStripBarraDeTarefas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1 });
            toolStripBarraDeTarefas.Location = new Point(125, 0);
            toolStripBarraDeTarefas.Name = "toolStripBarraDeTarefas";
            toolStripBarraDeTarefas.RenderMode = ToolStripRenderMode.Professional;
            toolStripBarraDeTarefas.Size = new Size(51, 353);
            toolStripBarraDeTarefas.TabIndex = 1;
            toolStripBarraDeTarefas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.plus__1_;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(48, 36);
            btnInserir.Text = "btnInserir";
            btnInserir.Click += btnInserir_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(48, 36);
            btnEditar.Text = "btnEditar";
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnDeletar
            // 
            btnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletar.Image = Properties.Resources.delete__1_;
            btnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            btnDeletar.ImageTransparentColor = Color.Magenta;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Padding = new Padding(7);
            btnDeletar.Size = new Size(48, 50);
            btnDeletar.Text = "btnDeletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(48, 6);
            // 
            // StatusRodape
            // 
            StatusRodape.Items.AddRange(new ToolStripItem[] { lblRodape });
            StatusRodape.Location = new Point(176, 331);
            StatusRodape.Name = "StatusRodape";
            StatusRodape.Padding = new Padding(1, 0, 12, 0);
            StatusRodape.Size = new Size(564, 22);
            StatusRodape.TabIndex = 2;
            StatusRodape.Text = "statusStrip1";
            // 
            // lblRodape
            // 
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(102, 17);
            lblRodape.Text = "___________________";
            // 
            // painelPrincipal
            // 
            painelPrincipal.Controls.Add(label1);
            painelPrincipal.Location = new Point(127, 0);
            painelPrincipal.Margin = new Padding(3, 2, 3, 2);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(613, 308);
            painelPrincipal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 310);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.AutoSize = true;
            lblTipoCadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblTipoCadastro.Location = new Point(130, 310);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(103, 17);
            lblTipoCadastro.TabIndex = 4;
            lblTipoCadastro.Text = "___________________";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(191, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click_1;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 353);
            Controls.Add(lblTipoCadastro);
            Controls.Add(painelPrincipal);
            Controls.Add(StatusRodape);
            Controls.Add(toolStripBarraDeTarefas);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "Locadora De Automoveis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripBarraDeTarefas.ResumeLayout(false);
            toolStripBarraDeTarefas.PerformLayout();
            StatusRodape.ResumeLayout(false);
            StatusRodape.PerformLayout();
            painelPrincipal.ResumeLayout(false);
            painelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStrip toolStripBarraDeTarefas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip StatusRodape;
        private Panel painelPrincipal;
        private ToolStripStatusLabel lblRodape;
        private Label label1;
        private Label lblTipoCadastro;
        private ToolStripMenuItem parceirosToolStripMenuItem;
        private ToolStripMenuItem cupomToolStripMenuItem;
        private ToolStripMenuItem grupoDeAutomoveisToolStripMenuItem;
        private ToolStripMenuItem planoDeCobrancaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
    }
}