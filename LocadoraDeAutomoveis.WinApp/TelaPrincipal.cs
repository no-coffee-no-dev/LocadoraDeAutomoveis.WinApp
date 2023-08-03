using LocadoraDeAutomoveis.Aplicacao.ModuloCupom;
using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloParceiro;
using LocadoraDeAutomoveis.WinApp.ModuloCupom;
using LocadoraDeAutomoveis.WinApp.ModuloParceiro;
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

            IRepositorioParceiro repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            IRepositorioCupom repositorioCupom = new RepositorioCupomOrm(dbContext);



            ValidadorParceiro validadorParceiro = new ValidadorParceiro();
            ValidadorCupom validadorCupom = new ValidadorCupom();



            ServicoParceiro servicoParceiro = new ServicoParceiro(repositorioParceiro, validadorParceiro);
            ServicoCupom servicoCupom = new ServicoCupom(repositorioCupom, validadorCupom);





            controladores.Add("ControladorParceiro", new ControladorParceiro(repositorioParceiro, servicoParceiro));
            controladores.Add("ControladorCupom", new ControladorCupom(repositorioCupom, repositorioParceiro, servicoCupom));

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

        private bool VerificaControladorVazio(ControladorBase controlador)
        {
            if (controlador == null)
                return true;
            else
                return false;
        }
    }
}