using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;

namespace LocadoraDeAutomoveis.WinApp.ModuloCliente
{
    public partial class TelaCadastroCliente : Form
    {
        private Cliente cliente;

        public event GravarRegistroDelegate<Cliente> onGravarRegistro;

        public TelaCadastroCliente()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Cliente ObterCliente()
        {

            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.CPF = txtCPF.Text;
            cliente.CNPJ = txtCNPJ.Text;
            cliente.CNH = txtCNH.Text;
            cliente.RG = txtRG.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = txtNumero.Text;


            if (cliente.TipoCliente == EnumTipoCliente.PessoaFisica)
            {
                rdbPessoaFisica.Checked = true;
                txtCPF.Text = cliente.CPF;

            }
            else
            {
                rdbPessoaJuridica.Checked = true;
                txtCNPJ.Text = cliente.CNPJ;
            }

            return cliente;
        }

        public void ConfigurarCliente(Cliente cliente)
        {

            this.cliente = cliente;

            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtTelefone.Text = cliente.Telefone;
            txtCPF.Text = cliente.CPF;
            txtCNPJ.Text = cliente.CNPJ;
            txtCNH.Text = cliente.CNH;
            txtRG.Text = cliente.RG;
            txtEstado.Text = cliente.Estado;
            txtCidade.Text = cliente.Cidade;
            txtBairro.Text = cliente.Bairro;
            txtRua.Text = cliente.Rua;
            txtNumero.Text = cliente.Numero;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void rdbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtCNPJ.Text = "";
            txtCNPJ.Enabled = false;
            txtCPF.Enabled = true;
        }

        private void rdbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtCPF.Enabled = false;
            txtCNPJ.Enabled = true;
        }
        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void rdbPessoaFisica_CheckedChanged_1(object sender, EventArgs e)
        {
            txtCPF.Enabled = true;
            txtCNPJ.Enabled = false;
        }

        private void rdbPessoaJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            txtCNPJ.Enabled = true;
            txtCPF.Enabled = false;
        }
    }
}