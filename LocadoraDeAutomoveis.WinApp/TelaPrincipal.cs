using LocadoraDeAutomoveis.Aplicacao.ModuloAutomovel;
using LocadoraDeAutomoveis.Aplicacao.ModuloCliente;
using LocadoraDeAutomoveis.Aplicacao.ModuloCupom;
using LocadoraDeAutomoveis.Aplicacao.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Aplicacao.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCliente;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.WinApp.ModuloAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloCliente;
using LocadoraDeAutomoveis.WinApp.ModuloCupom;
using LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloParceiro;
using LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraDeAutomoveis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private Dictionary<string, ControladorBase> controladores;

        private ControladorBase controlador;
        public TelaPrincipal()
        {
            InitializeComponent();
            Instancia = this;

            controladores = new Dictionary<string, ControladorBase>();
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


            IRepositorioCliente repositorioCliente = new RepositorioClienteOrm(dbContext);
            IRepositorioParceiro repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            IRepositorioCupom repositorioCupom = new RepositorioCupomOrm(dbContext);
            IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis = new RepositorioGrupoDeAutomoveisOrm(dbContext);
            IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca = new RepositorioPlanoDeCobrancaOrm(dbContext);
            IRepositorioAutomovel repositorioAutomovel = new RepositorioAutomovelOrm(dbContext);


            ValidadorParceiro validadorParceiro = new ValidadorParceiro();
            ValidadorCupom validadorCupom = new ValidadorCupom();
            ValidadorGrupoDeAutomoveis validadorGrupoDeAutomoveis = new ValidadorGrupoDeAutomoveis();
            ValidadorPlanoDeCobranca validadorPlanoDeCobranca = new ValidadorPlanoDeCobranca();
            ValidadorCliente validadorCliente = new ValidadorCliente();
            ValidadorAutomovel validadorAutomovel = new ValidadorAutomovel();



            ServicoParceiro servicoParceiro = new ServicoParceiro(repositorioParceiro, validadorParceiro);
            ServicoCupom servicoCupom = new ServicoCupom(repositorioCupom, validadorCupom);
            ServicoGrupoDeAutomoveis servicoGrupoDeAutomoveis = new ServicoGrupoDeAutomoveis(repositorioGrupoDeAutomoveis, validadorGrupoDeAutomoveis);
            ServicoPlanoDeCobranca servicoPlanoDeCobranca = new ServicoPlanoDeCobranca(repositorioPlanoDeCobranca, validadorPlanoDeCobranca);
            ServicoCliente servicoCliente = new ServicoCliente(repositorioCliente, validadorCliente);
            ServicoAutomovel servicoAutomovel = new ServicoAutomovel(repositorioAutomovel, validadorAutomovel);




            controladores.Add("ControladorParceiro", new ControladorParceiro(repositorioParceiro, servicoParceiro));
            controladores.Add("ControladorCupom", new ControladorCupom(repositorioCupom, repositorioParceiro, servicoCupom));
            controladores.Add("ControladorGrupoDeAutomoveis", new ControladorGrupoDeAutomoveis(repositorioGrupoDeAutomoveis, servicoGrupoDeAutomoveis));
            controladores.Add("ControladorPlanoDeCobranca", new ControladorPlanoDeCobranca(repositorioPlanoDeCobranca, repositorioGrupoDeAutomoveis, servicoPlanoDeCobranca));
            controladores.Add("ControladorCliente", new ControladorCliente(repositorioCliente, servicoCliente));
            controladores.Add("ControladorAutomovel", new ControladorAutomovel(repositorioAutomovel, repositorioGrupoDeAutomoveis, servicoAutomovel));

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

        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);
        }

        private void cupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCupom"]);
        }

        private void grupoDeAutomoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoDeAutomoveis"]);
        }
        private void planoDeCobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorPlanoDeCobranca"]);
        }
        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }

        private void automovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
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