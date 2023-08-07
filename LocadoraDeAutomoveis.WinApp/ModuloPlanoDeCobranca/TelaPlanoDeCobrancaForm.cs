using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Infra.Orm.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    public partial class TelaPlanoDeCobrancaForm : Form
    {
        private PlanoDeCobranca planoDeCobranca { get; set; }

        public event GravarEntidadeDelegate<PlanoDeCobranca> onGravarRegistro;
        public TelaPlanoDeCobrancaForm(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarListas(repositorioGrupoDeAutomoveis);
        }

        public PlanoDeCobranca PlanoDeCobranca
        {
            get
            {
                return planoDeCobranca;
            }
            set
            {
                ConfigurarCupom(planoDeCobranca);
            }
        }

        public void ConfigurarCupom(PlanoDeCobranca planoDeCobranca)
        {
            this.planoDeCobranca = planoDeCobranca;
            listGrupoDeAutomoveis.SelectedItem = planoDeCobranca.GrupoDeAutomoveis;
            listTipoDePlano.SelectedItem = planoDeCobranca.TipoDePlano;
            nmrPrecoDiaria.Value = planoDeCobranca.PrecoDaDiaria;
            nmrPrecoPorKM.Value = Convert.ToDecimal(planoDeCobranca.PrecoPorKM);
            nmrKmDisponiveis.Value = Convert.ToDecimal(planoDeCobranca.KmDisponiveis);
        }
        public PlanoDeCobranca ObterPlanoDeCobranca()
        {
            planoDeCobranca.GrupoDeAutomoveis = (GrupoDeAutomoveis)listGrupoDeAutomoveis.SelectedItem;
            planoDeCobranca.TipoDePlano = (TipoDePlanoEnum)listTipoDePlano.SelectedItem;
            planoDeCobranca.PrecoDaDiaria = nmrPrecoDiaria.Value;
            planoDeCobranca.PrecoPorKM = nmrPrecoPorKM.Value;
            planoDeCobranca.PrecoPorKM = nmrPrecoPorKM.Value;
            planoDeCobranca.KmDisponiveis = nmrKmDisponiveis.Value;
            return planoDeCobranca;
        }
        private void ConfigurarListas(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            foreach (var grupo in repositorioGrupoDeAutomoveis.RetornarTodos())
            {
                listGrupoDeAutomoveis.Items.Add(grupo);
            }
            listTipoDePlano.Items.Add(TipoDePlanoEnum.PlanoDiario);
            listTipoDePlano.Items.Add(TipoDePlanoEnum.PlanoControlado);
            listTipoDePlano.Items.Add(TipoDePlanoEnum.PlanoKMLivre);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            planoDeCobranca = ObterPlanoDeCobranca();

            Result resultado = onGravarRegistro(planoDeCobranca);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void listTipoDePlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoDePlanoEnum item = (TipoDePlanoEnum)listTipoDePlano.SelectedItem;
            
                if (item == TipoDePlanoEnum.PlanoDiario)
                {
                    nmrPrecoDiaria.Enabled = true;
                    nmrPrecoPorKM.Enabled = true;
                    nmrKmDisponiveis.Enabled = false;
                }
                if (item == TipoDePlanoEnum.PlanoControlado)
                {

                    nmrPrecoDiaria.Enabled = true;
                    nmrPrecoPorKM.Enabled = true;
                    nmrKmDisponiveis.Enabled = true;
                }
                if (item == TipoDePlanoEnum.PlanoKMLivre)
                {
                    nmrPrecoDiaria.Enabled = true;
                    nmrPrecoPorKM.Enabled = false;
                    nmrKmDisponiveis.Enabled = false;
                }
            
        }
    }
}
