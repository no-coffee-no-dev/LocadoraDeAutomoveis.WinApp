using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;

namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    public class ControladorPlanoDeCobranca : ControladorBase
    {
        private IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;
        private IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        private TabelaPlanoDeCobrancaControl tabelaPlanoDeCobranca;
        private ServicoPlanoDeCobranca servicoPlanoDeCobranca;

        public ControladorPlanoDeCobranca(IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, ServicoPlanoDeCobranca servicoPlanoDeCobranca)
        {
            this.repositorioPlanoDeCobranca = repositorioPlanoDeCobranca;
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.servicoPlanoDeCobranca = servicoPlanoDeCobranca;
        }

        public override void CarregarEntidades()
        {
            List<PlanoDeCobranca> planos = repositorioPlanoDeCobranca.RetornarTodos();

            tabelaPlanoDeCobranca.AtualizarRegistros(planos);

            stringRodape = string.Format("Visualizando {0} plan{1}", planos.Count, planos.Count == 1 ? "o" : "os");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaPlanoDeCobranca.ObtemIdSelecionado();

            PlanoDeCobranca planoSelecionada = repositorioPlanoDeCobranca.Busca(id);

            if (planoSelecionada == null)
            {
                MessageBox.Show("Selecione um plano primeiro",
                "Exclusão de Planos de Cobranca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o plano {planoSelecionada.TipoDePlano}?",
               "Exclusão de Planos de Cobranca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoPlanoDeCobranca.Excluir(planoSelecionada);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Planos de Cobranca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Guid? id = tabelaPlanoDeCobranca.ObtemIdSelecionado();

            PlanoDeCobranca planoSelecionada = repositorioPlanoDeCobranca.Busca(id);

            if (planoSelecionada == null)
            {
                MessageBox.Show("Selecione uma plano primeiro",
                "Edição de Planos de Cobranca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaPlanoDeCobrancaForm tela = new TelaPlanoDeCobrancaForm(repositorioGrupoDeAutomoveis);

            tela.onGravarRegistro += servicoPlanoDeCobranca.Atualizar;

            tela.ConfigurarCupom(planoSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaPlanoDeCobrancaForm tela = new TelaPlanoDeCobrancaForm(repositorioGrupoDeAutomoveis);

            tela.onGravarRegistro += servicoPlanoDeCobranca.Inserir;

            tela.ConfigurarCupom(new PlanoDeCobranca());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            };
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipPlanoDeCobranca();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPlanoDeCobranca == null)
                tabelaPlanoDeCobranca = new TabelaPlanoDeCobrancaControl();

            CarregarEntidades();

            return tabelaPlanoDeCobranca;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Planos de Cobranca";
        }
    }
}
