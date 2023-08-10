using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;

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
            AdicionarAComboBoxCliente(repositorioCliente);
        }

        public Condutor Condutor
        {
            get
            {
                return condutor;
            }
            set
            {
                ConfigurarCondutor(condutor);
            }
        }

        public void ConfigurarCondutor(Condutor condutor)
        {
            this.condutor = condutor;

            txt_NomeCondutor.Text = condutor.Nome;
            txt_EmailCondutor.Text = condutor.Email;
            txt_TelefoneCondutor.Text = condutor.Telefone;
            txt_CPFCondutor.Text = condutor.CPF;
            txt_CNHCondutor.Text = condutor.CNH;
            if (condutor.ValidadeCNH != DateTime.MinValue)
                dtp_ValidadeCNHCondutor.Value = condutor.ValidadeCNH;
            cbx_cliente.SelectedItem = condutor.Cliente;
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
            condutor.Cliente = cbx_cliente.SelectedItem as Cliente;
            condutor.Nome = txt_NomeCondutor.Text;
            condutor.Email = txt_TelefoneCondutor.Text;
            condutor.Telefone = txt_TelefoneCondutor.Text;
            condutor.CPF = txt_CPFCondutor.Text;
            condutor.CNH = txt_CNHCondutor.Text;
            condutor.ValidadeCNH = dtp_ValidadeCNHCondutor.Value;


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

        private void cb_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (condutor.Cliente != null)
            {
                if(cb_Cliente.Checked)
                {
                    txt_NomeCondutor.Text = condutor.Cliente.Nome;
                    txt_EmailCondutor.Text = condutor.Cliente.Email;
                    txt_TelefoneCondutor.Text = condutor.Cliente.Telefone;
                    txt_CPFCondutor.Text = condutor.Cliente.CPF;
                    txt_CNHCondutor.Text = condutor.Cliente.CNH;
                    if (condutor.ValidadeCNH != DateTime.MinValue)
                        dtp_ValidadeCNHCondutor.Value = condutor.ValidadeCNH;
                }
                else
                {
                    txt_NomeCondutor.Text = "";
                    txt_EmailCondutor.Text = "";
                    txt_TelefoneCondutor.Text = "";
                    txt_CPFCondutor.Text = "";
                    txt_CNHCondutor.Text = "";
                    if (condutor.ValidadeCNH != DateTime.MinValue)
                        dtp_ValidadeCNHCondutor.Value = condutor.ValidadeCNH;
                }

            }

        }
    }
}
