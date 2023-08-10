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

namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    public partial class TabelaPlanoDeCobrancaControl : UserControl
    {
        public TabelaPlanoDeCobrancaControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaPlanoDeCobranca.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "Id",
                    Visible = false
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "PrecoDaDiaria",
                    HeaderText = "Preco Da Diaria"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "PrecoPorKM",
                    HeaderText = "Preco Por KM"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "KmDisponiveis",
                    HeaderText = "Km Disponiveis"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "TipoDePlano",
                    HeaderText = "Tipo De Plano"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "GrupoDeAutomoveis",
                    HeaderText = "Grupo De Automoveis"
                }
            };

            return colunas;
        }

        public Guid? ObtemIdSelecionado()
        {
            return tabelaPlanoDeCobranca.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<PlanoDeCobranca> planos)
        {
            tabelaPlanoDeCobranca.Rows.Clear();

            foreach (PlanoDeCobranca plano in planos)
            {
                tabelaPlanoDeCobranca.Rows.Add(plano.Id, plano.PrecoDaDiaria, plano.PrecoPorKM != null ? plano.PrecoPorKM : "nao possui preco por Km", plano.KmDisponiveis == null? plano.KmDisponiveis : "nao possui Km disponiveis", plano.TipoDePlano, plano.GrupoDeAutomoveis.Nome);
            }
        }

        private void ConfigurarGrid()
        {
            tabelaPlanoDeCobranca.ConfigurarGridZebrado();

            tabelaPlanoDeCobranca.ConfigurarGridSomenteLeitura();

            tabelaPlanoDeCobranca.ConfigurarGridDockFill();

        }
    }
}
