using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;

namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCupom repositorioCupom;
        private IRepositorioTaxaServico repositorioTaxaServico;
        private IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;
        private IRepositorioCondutor repositorioCondutor;
        private IRepositorioFuncionario repositorioFuncionario;
        private TabelaAluguelControl tabelaAluguel;
        private ServicoAluguel servicoAluguel;

        public ControladorAluguel(IRepositorioAutomovel repositorioAutomovel, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioCupom repositorioCupom, IRepositorioTaxaServico repositorioTaxaServico, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IRepositorioCondutor repositorioCondutor, IRepositorioFuncionario repositorioFuncionario, ServicoAluguel servicoAluguel)
        {
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioCupom = repositorioCupom;
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.repositorioPlanoDeCobranca = repositorioPlanoDeCobranca;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoAluguel = servicoAluguel;
        }

        public override void CarregarEntidades()
        {
            List<Aluguel> alugueis = repositorioAluguel.RetornarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);

            stringRodape = string.Format("Visualizando {0} alugue{1}", alugueis.Count, alugueis.Count == 1 ? "l" : "is");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }




        public override void Deletar()
        {
            Guid? id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.Busca(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Exclusão de Alugueis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o aluguel do cliente {aluguelSelecionado.Cliente}?",
               "Exclusão de Alugueis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoAluguel.Excluir(aluguelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Alugueis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Guid? id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.Busca(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione uma aluguel primeiro",
                "Edição de Alugueis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm tela = new TelaAluguelForm(repositorioCupom, repositorioGrupoDeAutomoveis, repositorioCliente, repositorioPlanoDeCobranca, repositorioAutomovel, repositorioTaxaServico,repositorioCondutor,repositorioFuncionario);

            tela.onGravarRegistro += servicoAluguel.Atualizar;

            tela.ConfigurarAluguel(aluguelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaAluguelForm tela = new TelaAluguelForm(repositorioCupom,repositorioGrupoDeAutomoveis,repositorioCliente,repositorioPlanoDeCobranca, repositorioAutomovel,repositorioTaxaServico, repositorioCondutor, repositorioFuncionario);

            tela.onGravarRegistro += servicoAluguel.Inserir;
            
            tela.ConfigurarAluguel(new Aluguel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            };
        }



        public override void FinalizarAluguel()
        {
            Guid? id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.Busca(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione uma aluguel primeiro",
                "Edição de Alugueis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaDevolucaoAluguelForm tela = new TelaDevolucaoAluguelForm(repositorioCupom, repositorioGrupoDeAutomoveis, repositorioCliente, repositorioPlanoDeCobranca, repositorioAutomovel, repositorioTaxaServico, repositorioCondutor, repositorioFuncionario);

            tela.onGravarRegistro += servicoAluguel.Finalizar;

            tela.ConfigurarAluguel(aluguelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }











        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipAluguel();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarEntidades();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Alugueis";
        }
    }
}
