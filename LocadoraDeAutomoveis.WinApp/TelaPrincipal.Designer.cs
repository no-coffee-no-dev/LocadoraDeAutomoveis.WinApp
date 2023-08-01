﻿namespace LocadoraDeAutomoveis.WinApp
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
            toolStripBarraDeTarefas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblRodape = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            painelPrincipal = new Panel();
            label1 = new Label();
            lblTipoCadastro = new Label();
            parceirosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripBarraDeTarefas.SuspendLayout();
            lblRodape.SuspendLayout();
            painelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parceirosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(113, 19);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // toolStripBarraDeTarefas
            // 
            toolStripBarraDeTarefas.Dock = DockStyle.Left;
            toolStripBarraDeTarefas.GripStyle = ToolStripGripStyle.Hidden;
            toolStripBarraDeTarefas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1 });
            toolStripBarraDeTarefas.Location = new Point(126, 0);
            toolStripBarraDeTarefas.Name = "toolStripBarraDeTarefas";
            toolStripBarraDeTarefas.RenderMode = ToolStripRenderMode.Professional;
            toolStripBarraDeTarefas.Size = new Size(51, 450);
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
            // lblRodape
            // 
            lblRodape.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            lblRodape.Location = new Point(177, 428);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(623, 22);
            lblRodape.TabIndex = 2;
            lblRodape.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(102, 17);
            toolStripStatusLabel1.Text = "___________________";
            // 
            // painelPrincipal
            // 
            painelPrincipal.Controls.Add(label1);
            painelPrincipal.Location = new Point(128, 0);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(672, 410);
            painelPrincipal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 413);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.AutoSize = true;
            lblTipoCadastro.Location = new Point(128, 413);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(115, 15);
            lblTipoCadastro.TabIndex = 4;
            lblTipoCadastro.Text = "Cadastro de Clientes";
            // 
            // parceirosToolStripMenuItem
            // 
            parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            parceirosToolStripMenuItem.Size = new Size(180, 22);
            parceirosToolStripMenuItem.Text = "Parceiros";
            parceirosToolStripMenuItem.Click += parceirosToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoCadastro);
            Controls.Add(painelPrincipal);
            Controls.Add(lblRodape);
            Controls.Add(toolStripBarraDeTarefas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "Locadora De Automoveis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripBarraDeTarefas.ResumeLayout(false);
            toolStripBarraDeTarefas.PerformLayout();
            lblRodape.ResumeLayout(false);
            lblRodape.PerformLayout();
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
        private StatusStrip lblRodape;
        private Panel painelPrincipal;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private Label lblTipoCadastro;
        private ToolStripMenuItem parceirosToolStripMenuItem;
    }
}