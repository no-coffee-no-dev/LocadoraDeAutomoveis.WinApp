using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloParceiro
{
    public class ControladorParceiro : ControladorBase
    {
        private IRepositorioParceiro repositorioParceiro;
        private TabelaParceirosControl tabelaParceiros;
        private ServicoParceiro servicoParceiro;

        public ControladorParceiro(IRepositorioParceiro repositorioParceiro, ServicoParceiro servicoParceiro)
        {
            this.repositorioParceiro = repositorioParceiro;
            this.servicoParceiro = servicoParceiro;
        }

        public override void CarregarEntidades()
        {
            List<Parceiro> parceiros = repositorioParceiro.RetornarTodos();

            tabelaParceiros.AtualizarRegistros(parceiros);

            stringRodape = string.Format("Visualizando {0} parceiro{1}", parceiros.Count, parceiros.Count == 1 ? "" : "s");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            Guid id = tabelaParceiros.ObtemIdSelecionado();

            Parceiro parceiroSelecionada = repositorioParceiro.Busca(id);

            if (parceiroSelecionada == null)
            {
                MessageBox.Show("Selecione uma parceiro primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaParceiroForm tela = new TelaParceiroForm();

            tela.onGravarRegistro += servicoParceiro.Atualizar;

            tela.ConfigurarParceiro(parceiroSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaParceiroForm tela = new TelaParceiroForm();

            tela.onGravarRegistro += servicoParceiro.Inserir;

            tela.ConfigurarParceiro(new Parceiro());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            return new ConfigurarToolTipParceiro();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaParceiros == null)
                tabelaParceiros = new TabelaParceirosControl();

            CarregarEntidades();

            return tabelaParceiros;
        }
    

        public override string ObterTipoCadastro()
        {
            return "";
        }

    }
}
