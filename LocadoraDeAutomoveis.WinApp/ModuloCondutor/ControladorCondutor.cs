using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloCondutor;
using LocadoraDeAutomoveis.Aplicacao.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.WinApp.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    public class ControladorCondutor : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCondutor repositorioCondutor;
        private TabelaCondutorControl tabelaCondutor;
        private ServicoCondutor servicoCondutor;

        public ControladorCondutor(IRepositorioCliente repositorioCliente, IRepositorioCondutor repositorioCondutor, ServicoCondutor servicoCondutor)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioCondutor = repositorioCondutor;
            this.servicoCondutor = servicoCondutor;
        }

        public override void CarregarEntidades()
        {
            List<Condutor> condutor = repositorioCondutor.RetornarTodos();

            tabelaCondutor.AtualizarRegistros(condutor);

            stringRodape = string.Format("Visualizando {0} condutor{1}", condutor.Count, condutor.Count == 1 ? "" : "s");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaCondutor.ObtemIdSelecionado();

            Condutor condutorSelecionado = repositorioCondutor.Busca(id);

            if (condutorSelecionado == null)
            {
                MessageBox.Show("Selecione um Condutor primeiro",
                "Exclusão de Condutor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o Condutor {condutorSelecionado.Nome}?",
              "Exclusão de Condutor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCondutor.Excluir(condutorSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Funcionário",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Guid? id = tabelaCondutor.ObtemIdSelecionado();

            Condutor condutorSelecionado = repositorioCondutor.Busca(id);

            if (repositorioCondutor == null)
            {
                MessageBox.Show("Selecione uma Condutor primeiro",
                "Edição de Condutor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCondutorForm tela = new TelaCondutorForm(repositorioCondutor,repositorioCliente);

            tela.onGravarRegistro += servicoCondutor.Atualizar;

            tela.ConfigurarCondutor(condutorSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaCondutorForm tela = new TelaCondutorForm(repositorioCondutor, repositorioCliente);

            tela.onGravarRegistro += servicoCondutor.Inserir;

            tela.ConfigurarCondutor(new Condutor());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarTooltipFuncionario();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCondutor == null)
                tabelaCondutor = new TabelaCondutorControl();

            CarregarEntidades();

            return tabelaCondutor;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Condutor";
        }
    }
}
