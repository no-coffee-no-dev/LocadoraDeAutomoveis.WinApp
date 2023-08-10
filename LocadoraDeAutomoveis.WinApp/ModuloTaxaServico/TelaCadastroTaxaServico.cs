using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;

namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    public partial class TelaCadastroTaxaServico : Form
    {
        private TaxaServico taxaServico;

        public event GravarRegistroDelegate<TaxaServico> onGravarRegistro;
        public TelaCadastroTaxaServico()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public TaxaServico ObterTaxaServico()
        {

            taxaServico.Nome = txtNome.Text;
            taxaServico.Preco = Double.Parse(txtPreco.Text);

            if (rdbPrecoFixo.Checked)
            {
                taxaServico.PlanoDeCalculo = 0;
            }
            else
            {
                taxaServico.PlanoDeCalculo = EnumPlanoDeCalculo.COBRANCA_DIARIA;
            }

            return taxaServico;
        }

        public void ConfigurarTaxaServico(TaxaServico taxaServico)
        {

            this.taxaServico = taxaServico;

            txtNome.Text = taxaServico.Nome;
            txtPreco.Text = taxaServico.Preco.ToString();
            if (taxaServico.PlanoDeCalculo == EnumPlanoDeCalculo.PRECO_FIXO)
            {
                rdbPrecoFixo.Checked = true;
            }
            else
            {
                rdbCobrancaDiaria.Checked = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.taxaServico = ObterTaxaServico();

            Result resultado = onGravarRegistro(taxaServico);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
