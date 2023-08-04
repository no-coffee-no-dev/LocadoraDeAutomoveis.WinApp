using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Migrations;

namespace LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel
{

    public partial class TelaGrupoDeAutomoveisForm : Form
    {
        private GrupoDeAutomoveis grupoDeAutomoveis { get; set; }
        public event GravarEntidadeDelegate<GrupoDeAutomoveis> onGravarRegistro;
        public TelaGrupoDeAutomoveisForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public GrupoDeAutomoveis GrupoDeAutomoveis
        {
            get
            {
                return grupoDeAutomoveis;
            }
            set
            {
                ConfigurarGrupoDeAutomoveis(grupoDeAutomoveis);
            }
        }


        public void ConfigurarGrupoDeAutomoveis(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            this.grupoDeAutomoveis = grupoDeAutomoveis;
            txtNome.Text = grupoDeAutomoveis.Nome;
        }

        public GrupoDeAutomoveis ObterGrupoDeAutomoveis()
        {
            grupoDeAutomoveis.Nome = txtNome.Text;
            return grupoDeAutomoveis;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            grupoDeAutomoveis = ObterGrupoDeAutomoveis();

            Result resultado = onGravarRegistro(grupoDeAutomoveis);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
