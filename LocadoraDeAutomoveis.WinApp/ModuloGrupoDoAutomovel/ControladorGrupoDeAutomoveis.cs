using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;

namespace LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel
{
    public class ControladorGrupoDeAutomoveis : ControladorBase
    {
        IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        TabelaGrupoDeAutomoveisControl tabelaGrupoDeAutomoveis;
        ServicoGrupoDeAutomoveis servicoGrupoDeAutomoveis;

        public ControladorGrupoDeAutomoveis(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, ServicoGrupoDeAutomoveis servicoGrupoDeAutomoveis)
        {
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.servicoGrupoDeAutomoveis = servicoGrupoDeAutomoveis;
        }

        public override void CarregarEntidades()
        {
            List<GrupoDeAutomoveis> grupoDeAutomoveis = repositorioGrupoDeAutomoveis.RetornarTodos();

            tabelaGrupoDeAutomoveis.AtualizarRegistros(grupoDeAutomoveis);

            stringRodape = string.Format("Visualizando {0} Grupo{1} de Automov{2}", grupoDeAutomoveis.Count, grupoDeAutomoveis.Count == 1 ? "" : "s", grupoDeAutomoveis.Count == 1 ? "el" : "eis");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaGrupoDeAutomoveis.ObtemIdSelecionado();

            GrupoDeAutomoveis grupoSelecionada = repositorioGrupoDeAutomoveis.Busca(id);

            if (grupoSelecionada == null)
            {
                MessageBox.Show("Selecione um grupo primeiro",
                "Exclusão de Grupos de Automoveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o Grupo {grupoSelecionada.Nome}?",
               "Exclusão de Grupos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoGrupoDeAutomoveis.Excluir(grupoSelecionada);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Grupos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }




        public override void Editar()
        {
            Guid? id = tabelaGrupoDeAutomoveis.ObtemIdSelecionado();

            GrupoDeAutomoveis grupoSelecionado = repositorioGrupoDeAutomoveis.Busca(id);

            if (grupoSelecionado == null)
            {
                MessageBox.Show("Selecione uma cupom primeiro",
                "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaGrupoDeAutomoveisForm tela = new TelaGrupoDeAutomoveisForm();

            tela.onGravarRegistro += servicoGrupoDeAutomoveis.Atualizar;

            tela.ConfigurarGrupoDeAutomoveis(grupoSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }









        public override void Inserir()
        {
            TelaGrupoDeAutomoveisForm tela = new TelaGrupoDeAutomoveisForm();

            tela.onGravarRegistro += servicoGrupoDeAutomoveis.Inserir;

            tela.ConfigurarGrupoDeAutomoveis(new GrupoDeAutomoveis());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }







        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipGrupoDeAutomoveis();
        }




        public override UserControl ObterListagem()
        {
            if (tabelaGrupoDeAutomoveis == null)
                tabelaGrupoDeAutomoveis = new TabelaGrupoDeAutomoveisControl();

            CarregarEntidades();

            return tabelaGrupoDeAutomoveis;
        }





        public override string ObterTipoCadastro()
        {
            return "Cadastro de Grupo de Automoveis";
        }
    }
}
