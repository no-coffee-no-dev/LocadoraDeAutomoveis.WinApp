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

        private void Estado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//public TelaCadastroCliente()
//{
//            private Cliente cliente;
//        }
//        public Func<Cliente, Result<Cliente>> GravarRegistro
//{
//    get; set;
//}
//public TelaCadastroCliente()
//{
//    InitializeComponent();
//}

//public Cliente Cliente
//{
//    get
//    {
//        return cliente;
//    }
//    set
//    {
//        cliente = value;

//        txtNome.Text = cliente.Nome;
//        txtEmail.Text = cliente.Email;
//        txtTelefone.Text = cliente.Telefone;
//        txtCPF.Text = cliente.CPF;
//        txtCNPJ.Text = cliente.CNPJ;
//        txtEstado.Text = cliente.Estado;
//        txtCidade.Text = cliente.Cidade;
//        txtBairro.Text = cliente.Bairro;
//        txtRua.Text = cliente.Rua;
//        txtNumero.Text = cliente.Numero;

//        if (cliente.TipoCliente == EnumTipoCliente.PessoaFisica)
//        {
//            rdbPessoaFisica.Checked = true;
//            txtCPF.Text = cliente.Cpf;

//        }
//        else
//        {
//            rdbPessoaJuridica.Checked = true;
//            txtCNPJ.Text = cliente.Cnpj;
//        }
//    }
//}

//private void btnCancelar_Click(object sender, EventArgs e)
//{
//    txtNome.Clear();
//    txtEmail.Clear();
//    txtTelefone.Clear();
//    txtCPF.Clear();
//    txtCNPJ.Clear();
//    txtEstado.Clear();
//    txtCidade.Clear();
//    txtBairro.Clear();
//    txtRua.Clear();
//    txtNumero.Clear();
//    rdbPessoaFisica.Checked = false;
//    rdbPessoaJuridica.Checked = false;
//}

//private void btnGravar_Click(object sender, EventArgs e)
//{
//    cliente.Nome = txtNome.Text;
//    cliente.Email = txtEmail.Text;
//    cliente.Telefone = txtTelefone.Text;
//    cliente.Estado = txtEstado.Text;
//    cliente.Cidade = txtCidade.Text;
//    cliente.Bairro = txtBairro.Text;
//    cliente.Rua = txtRua.Text;
//    cliente.Numero = txtNumero.Text;


//    if (rdbPessoaFisica.Checked)
//    {
//        cliente.TipoCliente = EnumTipoCliente.PessoaFisica;
//        cliente.Cpf = txtCPF.Text;
//        cliente.Cnpj = "-";
//    }
//    else
//    {
//        cliente.TipoCliente = EnumTipoCliente.PessoaJuridica;
//        cliente.Cnpj = txtCNPJ.Text;
//        cliente.Cpf = "-";
//    }

//    var resultadoValidacao = GravarRegistro(cliente);


//}

//private void rdbPessoaFisica_CheckedChanged(object sender, EventArgs e)
//{
//    txtCNPJ.Text = "";
//    txtCNPJ.Enabled = false;
//    txtCPF.Enabled = true;
//}

//private void rdbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
//{
//    txtCPF.Text = "";
//    txtCPF.Enabled = false;
//    txtCNPJ.Enabled = true;
//}


//private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
//{
//    e = ImpedirNumeroECharsEspeciaisTextBox(e);
//}

//private static KeyPressEventArgs ImpedirNumeroECharsEspeciaisTextBox(KeyPressEventArgs e)
//{
//    if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
//    {
//        e.Handled = true;
//    }

//    if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
//    {
//        e.Handled = true;
//    }

//    return e;
//}

//private void TelaCadastroCliente_Closing(object sender, FormClosingEventArgs e)
//{
//    TelaPrincipal.Instancia.AtualizarRodape("");
//}

//private void TelaCadastroCliente_Load(object sender, EventArgs e)
//{
//    TelaPrincipal.Instancia.AtualizarRodape("");

//}


//private static void ImpedirLetrasCharEspeciais(KeyPressEventArgs e)
//{
//    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
//    {
//        e.Handled = true;
//    }
//}

//private void tbCPF_KeyPress(object sender, KeyPressEventArgs e)
//{
//    ImpedirLetrasCharEspeciais(e);
//}

//private void tbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
//{
//    ImpedirLetrasCharEspeciais(e);
//}

//private void tbNome_Leave(object sender, EventArgs e)
//{
//    if (txtNome.Text.Length < 2)
//    {
//        txtNome.Clear();
//    }
//}

//private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
//{
//    string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_@.";

//    if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper()) || char.IsControl(e.KeyChar)))
//    {
//        e.Handled = true;
//    }
//}