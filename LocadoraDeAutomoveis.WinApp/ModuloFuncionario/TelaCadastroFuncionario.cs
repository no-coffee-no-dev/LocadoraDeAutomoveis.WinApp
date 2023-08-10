using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    public partial class TelaCadastroFuncionario : Form
    {
        private Funcionario funcionario;
        public event GravarRegistroDelegate<Funcionario> onGravarRegistro;
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }
            set
            {
                ConfigurarFuncionario(funcionario);
            }
        }


        public void ConfigurarFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            txtNomeFuncionario.Text = funcionario.nome;
            if (funcionario.admissao != DateTime.MinValue)
            dTPAdmissao.Value = funcionario.admissao;
            txtSalario.Value = funcionario.salario;
        }

        public Funcionario ObterFuncionario()
        {
            funcionario.nome = txtNomeFuncionario.Text;
            funcionario.admissao = dTPAdmissao.Value;
            funcionario.salario = txtSalario.Value;


            return funcionario;


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.funcionario = ObterFuncionario();
            Result resultado = onGravarRegistro(funcionario);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
