using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
using LocadoraDeAutomoveis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    public partial class TabelaTaxaServicoControl : UserControl
    {
        public TabelaTaxaServicoControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaTaxaServicos.Columns.AddRange(ObterColunas());
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
                    Name = "Nome",
                    HeaderText = "Nome"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Preco",
                    HeaderText = "Preco"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "PlanoDeCalculo",
                    HeaderText = "Plano de Calculo"
                },
            };

            return colunas;
        }

        public Guid? ObtemIdSelecionado()
        {
            return tabelaTaxaServicos.ObterIDdoGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaTaxaServicos.ConfigurarGridZebrado();

            tabelaTaxaServicos.ConfigurarGridSomenteLeitura();

            tabelaTaxaServicos.ConfigurarGridDockFill();

        }

        public void AtualizarRegistros(List<TaxaServico> taxaServicos)
        {
            tabelaTaxaServicos.Rows.Clear();

            foreach (TaxaServico taxaServico in taxaServicos)
            {
                tabelaTaxaServicos.Rows.Add(taxaServico.Id, taxaServico.Nome, taxaServico.Preco, taxaServico.PlanoDeCalculo == 0? "Preço Fixo" : "Cobrança Diária");
            }
        }
    }
}
