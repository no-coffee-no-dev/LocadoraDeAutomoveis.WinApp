using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloTaxaServico;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;

namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    public class ControladorTaxaServico : ControladorBase
    {
        private IRepositorioTaxaServico repositorioTaxaServico;
        private TabelaTaxaServicoControl tabelaTaxaServico;
        private ServicoTaxaServico servicoTaxaServico;

        public ControladorTaxaServico(IRepositorioTaxaServico repositorioTaxaServico, ServicoTaxaServico servicoTaxaServico)
        {
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.servicoTaxaServico = servicoTaxaServico;
        }

        public override void CarregarEntidades()
        {
            List<TaxaServico> TaxaServicos = repositorioTaxaServico.RetornarTodos();

            tabelaTaxaServico.AtualizarRegistros(TaxaServicos);

            string Rodape = string.Format("Visualizando {0} TaxaServicos", TaxaServicos.Count);

            TelaPrincipal.Instancia.AtualizarRodape(Rodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaTaxaServico.ObtemIdSelecionado();

            TaxaServico TaxaServicoSelecionada = repositorioTaxaServico.Busca(id);

            if (TaxaServicoSelecionada == null)
            {
                MessageBox.Show("Selecione um TaxaServico primeiro",
                "Exclusão de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o TaxaServico {TaxaServicoSelecionada.Nome}?",
               "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoTaxaServico.Excluir(TaxaServicoSelecionada);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Cupons",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Guid? id = tabelaTaxaServico.ObtemIdSelecionado();

            TaxaServico TaxaServicoSelecionada = repositorioTaxaServico.Busca(id);

            if (TaxaServicoSelecionada == null)
            {
                MessageBox.Show("Selecione uma TaxaServico primeiro",
                "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroTaxaServico tela = new TelaCadastroTaxaServico();

            tela.onGravarRegistro += servicoTaxaServico.Atualizar;

            tela.ConfigurarTaxaServico(TaxaServicoSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaCadastroTaxaServico tela = new TelaCadastroTaxaServico();

            tela.onGravarRegistro += servicoTaxaServico.Inserir;

            tela.ConfigurarTaxaServico(new TaxaServico());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarTooltipTaxaServico();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTaxaServico == null)
                tabelaTaxaServico = new TabelaTaxaServicoControl();

            CarregarEntidades();

            return tabelaTaxaServico;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de TaxaServicos";
        }
    }
}