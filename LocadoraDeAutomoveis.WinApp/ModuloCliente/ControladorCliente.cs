using FluentResults;
using GeradorTestes.WinApp.ModuloCliente;
using LocadoraDeAutomoveis.Aplicacao.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;

namespace LocadoraDeAutomoveis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaCliente tabelaCliente;
        private ServicoCliente servicoCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente, ServicoCliente servicoCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.servicoCliente = servicoCliente;
        }

        public override void CarregarEntidades()
        {
            List<Cliente> clientes = repositorioCliente.RetornarTodos();

            tabelaCliente.AtualizarRegistros(clientes);

            string Rodape = string.Format("Visualizando {0} clientes", clientes.Count);

            TelaPrincipal.Instancia.AtualizarRodape(Rodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaCliente.ObtemIdSelecionado();

            Cliente ClienteSelecionada = repositorioCliente.Busca(id);

            if (ClienteSelecionada == null)
            {
                MessageBox.Show("Selecione um Cliente primeiro",
                "Exclusão de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o Cliente {ClienteSelecionada.Nome}?",
               "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCliente.Excluir(ClienteSelecionada);

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
            Guid? id = tabelaCliente.ObtemIdSelecionado();

            Cliente ClienteSelecionada = repositorioCliente.Busca(id);

            if (ClienteSelecionada == null)
            {
                MessageBox.Show("Selecione uma Cliente primeiro",
                "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroCliente tela = new TelaCadastroCliente();

            tela.onGravarRegistro += servicoCliente.Atualizar;

            tela.ConfigurarCliente(ClienteSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaCadastroCliente tela = new TelaCadastroCliente();

            tela.onGravarRegistro += servicoCliente.Inserir;

            tela.ConfigurarCliente(new Cliente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarTooltipCliente();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaCliente();

            CarregarEntidades();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }
    }
}