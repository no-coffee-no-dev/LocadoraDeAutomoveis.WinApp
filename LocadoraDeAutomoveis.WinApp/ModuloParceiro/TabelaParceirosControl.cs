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

namespace LocadoraDeAutomoveis.WinApp.ModuloParceiro
{
    public partial class TabelaParceirosControl : UserControl
    {
        public TabelaParceirosControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaParceiros.Columns.AddRange(ObterColunas());
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
                }
            };

            return colunas;
        }
        public Guid ObtemIdSelecionado()
         {
            return tabelaParceiros.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Parceiro> parceiros)
        {
            tabelaParceiros.Rows.Clear();

            foreach (Parceiro parceiro in parceiros)
            {
                tabelaParceiros.Rows.Add(parceiro.Id, parceiro.Nome);
            }
        }


        private void ConfigurarGrid()
        {
            tabelaParceiros.ConfigurarGridZebrado();

            tabelaParceiros.ConfigurarGridSomenteLeitura();

            tabelaParceiros.ConfigurarGridDockFill();

        }

    }
}
