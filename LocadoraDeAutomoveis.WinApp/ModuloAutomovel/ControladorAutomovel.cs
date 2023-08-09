using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloAutomovel;
using LocadoraDeAutomoveis.Aplicacao.ModuloCupom;
using LocadoraDeAutomoveis.Aplicacao.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.WinApp.ModuloCupom;
using LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca;

namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    public class ControladorAutomovel : ControladorBase
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        private TabelaAutomovelControl tabelaAutomovel;
        private ServicoAutomovel servicoAutomovel;

        public ControladorAutomovel(IRepositorioAutomovel repositorioAutomovel, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, ServicoAutomovel servicoAutomovel)
        {
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.servicoAutomovel = servicoAutomovel;
        }

        public override void CarregarEntidades()
        {
            List<Automovel> automoveis = repositorioAutomovel.RetornarTodos();

            tabelaAutomovel.AtualizarRegistros(automoveis);

            stringRodape = string.Format("Visualizando {0} automove{1}", automoveis.Count, automoveis.Count == 1 ? "l" : "is");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaAutomovel.ObtemIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.Busca(id);

            if (automovelSelecionado == null)
            {
                MessageBox.Show("Selecione um automovel primeiro",
                "Exclusão de Automoveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o automovel {automovelSelecionado.Marca}?",
               "Exclusão de Automoveis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoAutomovel.Excluir(automovelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Automoveis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Guid? id = tabelaAutomovel.ObtemIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.Busca(id);

            if (automovelSelecionado == null)
            {
                MessageBox.Show("Selecione uma automovel primeiro",
                "Edição de Automoveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAutomovelForm tela = new TelaAutomovelForm(repositorioGrupoDeAutomoveis);

            tela.onGravarRegistro += servicoAutomovel.Atualizar;

            tela.ConfigurarAutomovel(automovelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaAutomovelForm tela = new TelaAutomovelForm(repositorioGrupoDeAutomoveis);

            tela.onGravarRegistro += servicoAutomovel.Inserir;

            tela.ConfigurarAutomovel(new Automovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            };
        }













        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipAutomovel();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAutomovel == null)
                tabelaAutomovel = new TabelaAutomovelControl();

            CarregarEntidades();

            return tabelaAutomovel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Automoveis";
        }
    }
}
