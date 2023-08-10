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
            clienteToolStripMenuItem = new ToolStripMenuItem();
            automovelToolStripMenuItem = new ToolStripMenuItem();
            taxaDeServicoToolStripMenuItem = new ToolStripMenuItem();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripBarraDeTarefas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            StatusRodape = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            painelPrincipal = new Panel();
            lblTipoCadastro = new Label();
            menuStrip1.SuspendLayout();
            toolStripBarraDeTarefas.SuspendLayout();
            StatusRodape.SuspendLayout();
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
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(124, 393);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parceirosToolStripMenuItem, cupomToolStripMenuItem, grupoDeAutomoveisToolStripMenuItem, planoDeCobrancaToolStripMenuItem, clienteToolStripMenuItem, automovelToolStripMenuItem, taxaDeServicoToolStripMenuItem, aluguelToolStripMenuItem });
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parceirosToolStripMenuItem, cupomToolStripMenuItem, grupoDeAutomoveisToolStripMenuItem, planoDeCobrancaToolStripMenuItem, clienteToolStripMenuItem, funcionárioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(115, 19);
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
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(191, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click_1;
            // 
            // automovelToolStripMenuItem
            // 
            automovelToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            automovelToolStripMenuItem.Name = "automovelToolStripMenuItem";
            automovelToolStripMenuItem.Size = new Size(191, 22);
            automovelToolStripMenuItem.Text = "Automovel";
            automovelToolStripMenuItem.Click += automovelToolStripMenuItem_Click;
            // 
            // taxaDeServicoToolStripMenuItem
            // 
            taxaDeServicoToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            taxaDeServicoToolStripMenuItem.Name = "taxaDeServicoToolStripMenuItem";
            taxaDeServicoToolStripMenuItem.Size = new Size(191, 22);
            taxaDeServicoToolStripMenuItem.Text = "Taxa De Servico";
            taxaDeServicoToolStripMenuItem.Click += taxaDeServicoToolStripMenuItem_Click;
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(191, 22);
            aluguelToolStripMenuItem.Text = "Aluguel";
            aluguelToolStripMenuItem.Click += aluguelToolStripMenuItem_Click;
            // 
            // toolStripBarraDeTarefas
            // 
            toolStripBarraDeTarefas.Dock = DockStyle.Left;
            toolStripBarraDeTarefas.GripStyle = ToolStripGripStyle.Hidden;
            toolStripBarraDeTarefas.ImageScalingSize = new Size(20, 20);
            toolStripBarraDeTarefas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1, btnFiltrar, toolStripSeparator2 });
            toolStripBarraDeTarefas.Location = new Point(124, 0);
            toolStripBarraDeTarefas.Name = "toolStripBarraDeTarefas";
            toolStripBarraDeTarefas.RenderMode = ToolStripRenderMode.Professional;
            toolStripBarraDeTarefas.Size = new Size(51, 393);
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
            btnInserir.Text = "Inserir";
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
            btnEditar.Text = "Editar";
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
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(48, 6);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(48, 50);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(48, 6);
            // 
            // StatusRodape
            // 
            StatusRodape.ImageScalingSize = new Size(20, 20);
            StatusRodape.Items.AddRange(new ToolStripItem[] { lblRodape });
            StatusRodape.Location = new Point(175, 371);
            StatusRodape.Name = "StatusRodape";
            StatusRodape.Padding = new Padding(1, 0, 10, 0);
            StatusRodape.Size = new Size(629, 22);
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
            painelPrincipal.Location = new Point(127, 0);
            painelPrincipal.Margin = new Padding(3, 2, 3, 2);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(677, 352);
            painelPrincipal.TabIndex = 3;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.AutoSize = true;
            lblTipoCadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblTipoCadastro.Location = new Point(130, 354);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(103, 17);
            lblTipoCadastro.TabIndex = 4;
            lblTipoCadastro.Text = "___________________";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 393);
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
        private Label lblTipoCadastro;
        private ToolStripMenuItem parceirosToolStripMenuItem;
        private ToolStripMenuItem cupomToolStripMenuItem;
        private ToolStripMenuItem grupoDeAutomoveisToolStripMenuItem;
        private ToolStripMenuItem planoDeCobrancaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem automovelToolStripMenuItem;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem aluguelToolStripMenuItem;
        private ToolStripMenuItem taxaDeServicoToolStripMenuItem;
    }
}