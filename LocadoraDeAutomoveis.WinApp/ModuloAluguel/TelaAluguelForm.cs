using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel { get; set; }

        public event GravarEntidadeDelegate<Aluguel> onGravarRegistro;
        IRepositorioCupom repositorioCupom;
        IRepositorioAutomovel repositorioAutomovel;
        public TelaAluguelForm(IRepositorioCupom repositorioCupom, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioCliente repositorioCliente, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IRepositorioAutomovel repositorioAutomovel)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.repositorioCupom = repositorioCupom;
            this.repositorioAutomovel = repositorioAutomovel;
            listAutomovel.Enabled = false;
            ConfigurarListas(repositorioGrupoDeAutomoveis, repositorioCliente, repositorioPlanoDeCobranca);
        }



        public Aluguel Aluguel
        {
            get
            {
                return aluguel;
            }
            set
            {
                ConfigurarAluguel(aluguel);
            }
        }

        public void ConfigurarAluguel(Aluguel aluguel)
        {
            this.aluguel = aluguel;
            listAutomovel.SelectedItem = aluguel.Automovel;
            listCliente.SelectedItem = aluguel.Cliente;
            listGrupoDeAutomoveis.SelectedItem = aluguel.GrupoDeAutomoveis;
            listPlanoDeCobranca.SelectedItem = aluguel.PlanoDeCobranca;
            //listFuncionario.SelectedItem = aluguel.Funcionario;
            //listaTaxasEServicos.SelectedItems = aluguel.TaxasEServicos;
            //listCondutor.SelectedItem = aluguel.Condutor;
            if (aluguel.DataDoAluguel != DateTime.MinValue)
                datePickerDataDoAluguel.Value = aluguel.DataDoAluguel;
            if (aluguel.DataDaPrevistaDevolucao != DateTime.MinValue)
                datePickerDataDaDevolucao.Value = aluguel.DataDaPrevistaDevolucao;

        }
        public Aluguel ObterAluguel()
        {

            aluguel.Automovel = (Automovel)listAutomovel.SelectedItem;
            aluguel.Cliente = (Cliente)listCliente.SelectedItem;
            aluguel.GrupoDeAutomoveis = (GrupoDeAutomoveis)listGrupoDeAutomoveis.SelectedItem;
            aluguel.PlanoDeCobranca = (PlanoDeCobranca)listPlanoDeCobranca.SelectedItem;
            aluguel.DataDoAluguel = datePickerDataDoAluguel.Value;
            aluguel.DataDaPrevistaDevolucao = datePickerDataDaDevolucao.Value;
           // aluguel.ValorFinal = aluguel.CalcularValorFinal();



            return aluguel;
        }


        private void listAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automovel automovel = (Automovel)listAutomovel.SelectedItem;
            txtKmDoAutomovel.Text = automovel.KmRodados.ToString();
        }

        private void btnAplicarCupom_Click(object sender, EventArgs e)
        {
            Cupom cupom = null;
            if (txtBuscarCupom.Text != "")
                cupom = repositorioCupom.SelecionarPorNome(txtBuscarCupom.Text);
        }
        private void ConfigurarListas(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioCliente repositorioCliente, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca)
        {

            foreach (var item in repositorioCliente.RetornarTodos())
            {
                listCliente.Items.Add(item);
            }
            foreach (var item in repositorioGrupoDeAutomoveis.RetornarTodos())
            {
                listGrupoDeAutomoveis.Items.Add(item);
            }
            foreach (var item in repositorioPlanoDeCobranca.RetornarTodos())
            {
                listPlanoDeCobranca.Items.Add(item);
            }


        }

        private void listGrupoDeAutomoveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAutomovel.Enabled = true;
            foreach (var item in repositorioAutomovel.RetornarCarrosFiltrados((GrupoDeAutomoveis)listGrupoDeAutomoveis.SelectedItem))
            {
                listAutomovel.Items.Add(item);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            aluguel = ObterAluguel();

            Result resultado = onGravarRegistro(aluguel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
