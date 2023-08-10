using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using LocadoraDeAutomoveis.WinApp.Compartilhado.IoC;
using LocadoraDeAutomoveis.WinApp.ModuloAluguel;
using LocadoraDeAutomoveis.WinApp.ModuloAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloCliente;
using LocadoraDeAutomoveis.WinApp.ModuloCondutor;
using LocadoraDeAutomoveis.WinApp.ModuloCupom;
using LocadoraDeAutomoveis.WinApp.ModuloFuncionario;
using LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloParceiro;
using LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.WinApp.ModuloTaxaServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraDeAutomoveis.WinApp
{
    public partial class TelaPrincipal : Form
    {

        private IoC IoC;
        private ControladorBase controlador;
        public TelaPrincipal()
        {
            InitializeComponent();
            Instancia = this;

            IoC = new IoC_ComInjecaoDependencia();
            this.ConfigurarDialog();
            ConfigurarControladores();

        }

        public static TelaPrincipal Instancia
        {
            get;
            private set;
        }
        public void AtualizarRodape(string mensagem)
        {
            lblRodape.Text = mensagem;
        }



        #region Configuracoes
        private void ConfigurarBotoes(ConfigurarToolTipBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnDeletar.Enabled = configuracao.ExcluirHabilitado;

        }

        private void ConfigurarTooltips(ConfigurarToolTipBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnDeletar.ToolTipText = configuracao.TooltipExcluir;

        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterStringRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfigurarToolTipBase configuracao = controlador.ObtemConfiguracaoTooltip();

            if (configuracao != null)
            {
                toolStripBarraDeTarefas.Enabled = true;

                lblTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObterListagem();

            painelPrincipal.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            painelPrincipal.Controls.Add(listagemControl);
        }
        private void ConfigurarControladores()
        {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appSettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeAutomoveisDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeAutomoveisDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
            {
                dbContext.Database.Migrate();
            }



        }
        #endregion 

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador) == false)
                controlador.Inserir();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador) == false)
                controlador.Editar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador) == false)
                controlador.Deletar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador) == false)
                controlador.Filtrar();
        }

        private void btnFinalizarAluguel_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador) == false)
                controlador.FinalizarAluguel();
        }
        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorParceiro>());
        }

        private void cupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorCupom>());
        }
        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorAluguel>());
        }
        private void grupoDeAutomoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorGrupoDeAutomoveis>());
        }
        private void planoDeCobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorPlanoDeCobranca>());
        }
        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorCliente>());
        }
        private void taxaDeServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorTaxaServico>());
        }

        private void automovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorAutomovel>());
        }
        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorFuncionario>());
        }
        private void condutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(IoC.Get<ControladorCondutor>());
        }
        private bool VerificaControladorVazio(ControladorBase controlador)
        {
            if (controlador == null)
                return true;
            else
                return false;

        }

    }
}