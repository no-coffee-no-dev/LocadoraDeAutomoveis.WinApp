using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
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
        Cupom? cupom = new();
        public event GravarEntidadeDelegate<Aluguel> onGravarRegistro;
        IRepositorioCupom repositorioCupom;
        IRepositorioAutomovel repositorioAutomovel;
        public TelaAluguelForm(IRepositorioCupom repositorioCupom, IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioCliente repositorioCliente, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IRepositorioAutomovel repositorioAutomovel, IRepositorioTaxaServico repositorioTaxaServico, IRepositorioCondutor repositorioCondutor, IRepositorioFuncionario repositorioFuncionario)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.repositorioCupom = repositorioCupom;
            this.repositorioAutomovel = repositorioAutomovel;
            listAutomovel.Enabled = false;
            ConfigurarListas(repositorioGrupoDeAutomoveis, repositorioCliente, repositorioPlanoDeCobranca, repositorioTaxaServico, repositorioFuncionario, repositorioCondutor);
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
            listCliente.SelectedItem = aluguel.Cliente;
            listGrupoDeAutomoveis.SelectedItem = aluguel.GrupoDeAutomoveis;
            listPlanoDeCobranca.SelectedItem = aluguel.PlanoDeCobranca;
            listAutomovel.SelectedItem = aluguel.Automovel;
            listFuncionario.SelectedItem = aluguel.Funcionario;
            listaTaxasEServicos.SelectedItems.Add(aluguel.TaxasEServicos);
            listCondutor.SelectedItem = aluguel.Condutor;
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
            aluguel.Condutor = (Condutor)listCondutor.SelectedItem;
            aluguel.Funcionario = (Funcionario)listFuncionario.SelectedItem;
            aluguel.TaxasEServicos = new();
            foreach (var item in listaTaxasEServicos.CheckedItems)
            {
                aluguel.TaxasEServicos.Add((TaxaServico)item);
            }
            aluguel.DataDoAluguel = datePickerDataDoAluguel.Value.Date;
            aluguel.DataDaPrevistaDevolucao = datePickerDataDaDevolucao.Value.Date;
            aluguel.ValorFinal = aluguel.CalcularValorFinal();
            aluguel.Cupom = cupom;


            return aluguel;
        }


        private void listAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automovel automovel = (Automovel)listAutomovel.SelectedItem;
            txtKmDoAutomovel.Text = automovel.KmRodados.ToString();
        }

        private void btnAplicarCupom_Click(object sender, EventArgs e)
        {
            if (txtBuscarCupom.Text != "")
                cupom = repositorioCupom.SelecionarPorNome(txtBuscarCupom.Text);
        }
        private void ConfigurarListas(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IRepositorioCliente repositorioCliente, IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IRepositorioTaxaServico repositorioTaxaServico, IRepositorioFuncionario repositorioFuncionario, IRepositorioCondutor repositorioCondutor)
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
            foreach (var item in repositorioTaxaServico.RetornarTodos())
            {
                listaTaxasEServicos.Items.Add(item);
            }
            foreach (var item in repositorioCondutor.RetornarTodos())
            {
                listCondutor.Items.Add(item);
            }
            foreach (var item in repositorioFuncionario.RetornarTodos())
            {
                listFuncionario.Items.Add(item);
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
