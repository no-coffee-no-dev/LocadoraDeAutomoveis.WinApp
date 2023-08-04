using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel
{
    public partial class TabelaGrupoDeAutomoveisControl : UserControl
    {
        public TabelaGrupoDeAutomoveisControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaGrupoDeAutomoveis.Columns.AddRange(ObterColunas());
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

        public Guid? ObtemIdSelecionado()
        {
            return tabelaGrupoDeAutomoveis.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<GrupoDeAutomoveis> gruposDeAutomoveis)
        {
            tabelaGrupoDeAutomoveis.Rows.Clear();

            foreach (GrupoDeAutomoveis grupoDeAutomovel in gruposDeAutomoveis)
            {
                tabelaGrupoDeAutomoveis.Rows.Add(grupoDeAutomovel.Id, grupoDeAutomovel.Nome);
            }
        }
        private void ConfigurarGrid()
        {
            tabelaGrupoDeAutomoveis.ConfigurarGridZebrado();

            tabelaGrupoDeAutomoveis.ConfigurarGridSomenteLeitura();

            tabelaGrupoDeAutomoveis.ConfigurarGridDockFill();

        }
    }
}
