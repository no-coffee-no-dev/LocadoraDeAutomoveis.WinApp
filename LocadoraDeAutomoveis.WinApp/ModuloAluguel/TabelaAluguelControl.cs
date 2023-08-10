using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloAutomovel;
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
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
               
            InitializeComponent();
            ConfigurarGrid();
            tabelaAluguel.Columns.AddRange(ObterColunas());
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
                    Name = "ValorFinal",
                    HeaderText = "Valor Final"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Cliente",
                    HeaderText = "Cliente"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "GrupoDeAutomoveis",
                    HeaderText = "GrupoDeAutomoveis"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "DataDoAluguel",
                    HeaderText = "Data Do Aluguel"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "DataDaPrevistaDevolucao",
                    HeaderText = "Data Prevista Devolucao "
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "PlanoDeCobranca",
                    HeaderText = "Plano De Cobranca"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Cupom",
                    HeaderText = "Desconto do Cupom"
                }
            };

            return colunas;
        }

        public Guid? ObtemIdSelecionado()
        {
            return tabelaAluguel.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            tabelaAluguel.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {                
                tabelaAluguel.Rows.Add(aluguel.Id, aluguel.ValorFinal, aluguel.Cliente.Nome, aluguel.GrupoDeAutomoveis.Nome, aluguel.DataDoAluguel.ToString("d"), aluguel.DataDaPrevistaDevolucao.ToString("d"), aluguel.PlanoDeCobranca.TipoDePlano, aluguel.Cupom?.Valor == null ? "Nao possui Cupom" : aluguel.Cupom?.Valor);
            }
        }

        private void ConfigurarGrid()
        {
            tabelaAluguel.ConfigurarGridZebrado();

            tabelaAluguel.ConfigurarGridSomenteLeitura();

            tabelaAluguel.ConfigurarGridDockFill();

        }
    }
}
