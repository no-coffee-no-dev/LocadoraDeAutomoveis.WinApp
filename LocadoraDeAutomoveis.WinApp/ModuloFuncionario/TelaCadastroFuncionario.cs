using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
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

        public Funcionario ObterFuncionario()
        {
            funcionario.nome = txtNomeFuncionario.Text;
            funcionario.admissao = dTPAdmissao.Value;
            funcionario.salario = Convert.ToDecimal(txtSalario);


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
