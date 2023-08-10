using LocadoraDeAutomoveis.Aplicacao.ModuloAluguel;
using LocadoraDeAutomoveis.Aplicacao.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.WinApp.ModuloAutomovel;

namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCupom repositorioCupom;
        private IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;
        private TabelaAluguelControl tabelaAluguel;
        private ServicoAluguel servicoAluguel;

        public ControladorAluguel(IRepositorioAutomovel repositorioAutomovel, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioCupom repositorioCupom, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, ServicoAluguel servicoAluguel)
        {
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioCupom = repositorioCupom;
            this.repositorioPlanoDeCobranca = repositorioPlanoDeCobranca;
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
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaAluguelForm tela = new TelaAluguelForm(repositorioCupom,repositorioGrupoDeAutomoveis,repositorioCliente,repositorioPlanoDeCobranca, repositorioAutomovel);

            tela.onGravarRegistro += servicoAluguel.Inserir;
            
            tela.ConfigurarAluguel(new Aluguel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarEntidades();
            };
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
