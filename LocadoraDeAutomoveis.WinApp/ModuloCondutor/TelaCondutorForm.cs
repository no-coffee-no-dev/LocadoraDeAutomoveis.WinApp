using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Infra.Orm.Migrations;

namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    public partial class TelaCondutorForm : Form
    {
        private Condutor condutor;
        public event GravarRegistroDelegate<Condutor> onGravarRegistro;

        public TelaCondutorForm(IRepositorioCondutor repositorioCondutor, IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Condutor Condutor
        {
            get
            {
                return condutor;
            }
            set
            {
                ConfigurarCondutor(condutor, condutor.cliente);
            }
        }

        public void ConfigurarCondutor(Condutor condutor, Cliente cliente)

        {
            this.condutor = condutor;
            if (condutor.cliente != null)
            {
                cbx_cliente.SelectedItem = condutor.cliente;
                return;


            }

            txt_NomeCondutor.Text = condutor.nome;
            txt_EmailCondutor.Text = condutor.email;
            txt_TelefoneCondutor.Text = condutor.telefone;
            txt_CPFCondutor.Text = condutor.CPF;
            txt_CNHCondutor.Text = condutor.CNH;
            if (condutor.validadeCNH != DateTime.MinValue)
                dtp_ValidadeCNHCondutor.Value = condutor.validadeCNH;
        }
        public void AdicionarAComboBoxCliente(IRepositorioCliente repositorioCliente)
        {
            foreach (Cliente cliete in repositorioCliente.RetornarTodos())
            {
                cbx_cliente.Items.Add(cliete);
            }
        }
        public Condutor ObterCondutor()
        {
            Cliente cliente = cbx_cliente.SelectedItem as Cliente;
            condutor.nome = txt_NomeCondutor.Text;
            condutor.email = txt_TelefoneCondutor.Text;
            condutor.telefone = txt_TelefoneCondutor.Text;
            condutor.CPF = txt_CPFCondutor.Text;
            condutor.CNH = txt_CNHCondutor.Text;
            condutor.validadeCNH = dtp_ValidadeCNHCondutor.Value;


            return condutor;


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.condutor = ObterCondutor();
            Result resultado = onGravarRegistro(condutor);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
