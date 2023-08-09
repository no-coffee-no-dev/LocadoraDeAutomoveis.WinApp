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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            toolStripBarraDeTarefas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            painelPrincipal = new Panel();
            lblTipoCadastro = new Label();
            StatusRodape = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            taxaDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripBarraDeTarefas.SuspendLayout();
            StatusRodape.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(157, 600);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, taxaDeServiçoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(142, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // toolStripBarraDeTarefas
            // 
            toolStripBarraDeTarefas.Dock = DockStyle.Left;
            toolStripBarraDeTarefas.GripStyle = ToolStripGripStyle.Hidden;
            toolStripBarraDeTarefas.ImageScalingSize = new Size(20, 20);
            toolStripBarraDeTarefas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1 });
            toolStripBarraDeTarefas.Location = new Point(157, 0);
            toolStripBarraDeTarefas.Name = "toolStripBarraDeTarefas";
            toolStripBarraDeTarefas.RenderMode = ToolStripRenderMode.Professional;
            toolStripBarraDeTarefas.Size = new Size(51, 600);
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
            btnInserir.Click += btnInserir_Click;
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
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(48, 6);
            // 
            // painelPrincipal
            // 
            painelPrincipal.Location = new Point(152, 0);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(761, 548);
            painelPrincipal.TabIndex = 2;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.AutoSize = true;
            lblTipoCadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblTipoCadastro.Location = new Point(152, 551);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(143, 23);
            lblTipoCadastro.TabIndex = 6;
            lblTipoCadastro.Text = "___________________";
            // 
            // StatusRodape
            // 
            StatusRodape.ImageScalingSize = new Size(20, 20);
            StatusRodape.Items.AddRange(new ToolStripItem[] { lblRodape });
            StatusRodape.Location = new Point(208, 574);
            StatusRodape.Name = "StatusRodape";
            StatusRodape.Padding = new Padding(1, 0, 16, 0);
            StatusRodape.Size = new Size(706, 26);
            StatusRodape.TabIndex = 5;
            StatusRodape.Text = "statusStrip1";
            // 
            // lblRodape
            // 
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(123, 20);
            lblRodape.Text = "___________________";
            // 
            // taxaDeServiçoToolStripMenuItem
            // 
            taxaDeServiçoToolStripMenuItem.Name = "taxaDeServiçoToolStripMenuItem";
            taxaDeServiçoToolStripMenuItem.Size = new Size(224, 26);
            taxaDeServiçoToolStripMenuItem.Text = "Taxa de Serviço";
            taxaDeServiçoToolStripMenuItem.Click += taxaDeServiçoToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblTipoCadastro);
            Controls.Add(StatusRodape);
            Controls.Add(painelPrincipal);
            Controls.Add(toolStripBarraDeTarefas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private Panel painelPrincipal;
        private Label lblTipoCadastro;
        private StatusStrip StatusRodape;
        private ToolStripStatusLabel lblRodape;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem taxaDeServiçoToolStripMenuItem;
    }
}