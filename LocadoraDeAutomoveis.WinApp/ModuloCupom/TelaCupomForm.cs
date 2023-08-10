using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
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

namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{

    public partial class TelaCupomForm : Form
    {
        private Cupom cupom { get; set; }

        public event GravarEntidadeDelegate<Cupom> onGravarRegistro;
        public TelaCupomForm(IRepositorioParceiro repositorioParceiro)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarListaDeParceiro(repositorioParceiro);
        }

        public Cupom Cupom
        {
            get
            {
                return cupom;
            }
            set
            {
                ConfigurarCupom(cupom);
            }
        }

        public void ConfigurarCupom(Cupom cupom)
        {
            this.cupom = cupom;
            txtNome.Text = cupom.Nome;
            nmrValor.Value = cupom.Valor;
            if (cupom.DataDeValidade != DateTime.MinValue)
                dtpickerValidade.Value = cupom.DataDeValidade.Date;
            listParceiro.SelectedItem = cupom.Parceiro;
        }

        public Cupom ObterCupom()
        {
            cupom.Nome = txtNome.Text;
            cupom.Valor = nmrValor.Value;
            cupom.DataDeValidade = dtpickerValidade.Value;
            cupom.Parceiro = (Parceiro)listParceiro.SelectedItem;
            return cupom;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cupom = ObterCupom();

            Result resultado = onGravarRegistro(cupom);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
        private void ConfigurarListaDeParceiro(IRepositorioParceiro repositorioParceiro)
        {
            foreach (var parceiro in repositorioParceiro.RetornarTodos())
            {
                listParceiro.Items.Add(parceiro);
            }
        }
    }
}
