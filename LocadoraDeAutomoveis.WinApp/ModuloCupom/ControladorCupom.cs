using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloCupom;
using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.WinApp.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{
    public class ControladorCupom : ControladorBase
    {
        private IRepositorioCupom repositorioCupom;
        private IRepositorioParceiro repositorioParceiro;
        private TabelaCuponsControl tabelaCupons;
        private ServicoCupom servicoCupom;

        public ControladorCupom(IRepositorioCupom repositorioCupom, IRepositorioParceiro repositorioParceiro, ServicoCupom servicoCupom)
        {
            this.repositorioCupom = repositorioCupom;
            this.repositorioParceiro = repositorioParceiro;
            this.servicoCupom = servicoCupom;
        }

        public override void CarregarEntidades()
        {
            List<Cupom> cupons = repositorioCupom.RetornarTodos();

            tabelaCupons.AtualizarRegistros(cupons);

            stringRodape = string.Format("Visualizando {0} parceiro{1}", cupons.Count, cupons.Count == 1 ? "" : "s");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid id = tabelaCupons.ObtemIdSelecionado();

            Cupom cupomSelecionada = repositorioCupom.Busca(id);

            if (cupomSelecionada == null)
            {
                MessageBox.Show("Selecione um cupom primeiro",
                "Exclusão de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o cupom {cupomSelecionada.Nome}?",
               "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCupom.Excluir(cupomSelecionada);

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
            Guid id = tabelaCupons.ObtemIdSelecionado();

            Cupom cupomSelecionada = repositorioCupom.Busca(id);

            if (cupomSelecionada == null)
            {
                MessageBox.Show("Selecione uma cupom primeiro",
                "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCupomForm tela = new TelaCupomForm(repositorioParceiro);

            tela.onGravarRegistro += servicoCupom.Atualizar;

            tela.ConfigurarCupom(cupomSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaCupomForm tela = new TelaCupomForm(repositorioParceiro);

            tela.onGravarRegistro += servicoCupom.Inserir;

            tela.ConfigurarCupom(new Cupom());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipCupom();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCupons == null)
                tabelaCupons = new TabelaCuponsControl();

            CarregarEntidades();

            return tabelaCupons;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cupons";
        }
    }
}
