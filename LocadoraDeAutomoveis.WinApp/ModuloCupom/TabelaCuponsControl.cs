using LocadoraDeAutomoveis.Dominio.ModuloCupom;
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

namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{
    public partial class TabelaCuponsControl : UserControl
    {
        public TabelaCuponsControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaCupons.Columns.AddRange(ObterColunas());
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
                    Name = "Parceiro",
                    HeaderText = "Parceiro"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Valor",
                    HeaderText = "Valor"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "DataDeValidade",
                    HeaderText = "Validade"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Expirado",
                    HeaderText = "Espirado"
                }
            };

            return colunas;
        }
        public Guid ObtemIdSelecionado()
        {
            return tabelaCupons.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Cupom> cupons)
        {
            tabelaCupons.Rows.Clear();

            foreach (Cupom cupom in cupons)
            {
                tabelaCupons.Rows.Add(cupom.Id, cupom.Nome,cupom.Parceiro.Nome,cupom.Valor, cupom.DataDeValidade.ToString("d"), cupom.Expirado? "sim" : "nao");
            }
        }


        private void ConfigurarGrid()
        {
            tabelaCupons.ConfigurarGridZebrado();

            tabelaCupons.ConfigurarGridSomenteLeitura();

            tabelaCupons.ConfigurarGridDockFill();

        }
    }
}
