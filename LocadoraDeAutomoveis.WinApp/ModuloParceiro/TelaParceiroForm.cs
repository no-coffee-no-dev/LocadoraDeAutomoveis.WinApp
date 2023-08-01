using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloParceiro
{
    public partial class TelaParceiroForm : Form
    {
        private Parceiro parceiro { get; set; }

        public event GravarEntidadeDelegate<Parceiro> onGravarRegistro;
        public TelaParceiroForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Parceiro Parceiro
        {
            get
            {
                return parceiro;
            }
            set
            {
                ConfigurarParceiro(parceiro);
            }
        }


        public void ConfigurarParceiro(Parceiro parceiro)
        {
            this.parceiro = parceiro;
            txtNome.Text = parceiro.Nome;
        }
        public Parceiro ObterParceiro()
        {
            parceiro.Nome = txtNome.Text;
            return parceiro;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            parceiro = ObterParceiro();

            Result resultado = onGravarRegistro(parceiro);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
