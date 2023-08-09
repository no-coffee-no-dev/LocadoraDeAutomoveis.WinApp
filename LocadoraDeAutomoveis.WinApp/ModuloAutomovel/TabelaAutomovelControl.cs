using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    public partial class TabelaAutomovelControl : UserControl
    {
        public TabelaAutomovelControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaAutomovel.Columns.AddRange(ObterColunas());
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
                    Name = "Modelo",
                    HeaderText = "Modelo"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Marca",
                    HeaderText = "Marca"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Placa",
                    HeaderText = "Placa"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Ano",
                    HeaderText = "Ano"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "GrupoDeAutomovel",
                    HeaderText = "Grupo de Automovel"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "TipoDeCombustivel",
                    HeaderText = "Tipo De Combustivel "
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Cor",
                    HeaderText = "Cor"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "KmsRodados",
                    HeaderText = "Km's Rodados"
                },

                 new DataGridViewImageColumn
                {
                    Name = "Foto",
                    HeaderText = "Foto",
                    ImageLayout = (DataGridViewImageCellLayout)ImageLayout.Stretch
                }
            };

            return colunas;
        }

        public Guid? ObtemIdSelecionado()
        {
            return tabelaAutomovel.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Automovel> automoveis)
        {
            tabelaAutomovel.Rows.Clear();
            
            foreach (Automovel automovel in automoveis)
            {
                Image foto = null;
                foto = TelaAutomovelForm.ConverterByteEmImagem(automovel, foto);
                tabelaAutomovel.Rows.Add(automovel.Id, automovel.Modelo, automovel.Marca,automovel.Placa,automovel.Ano.ToString("yyyy"), automovel.GrupoDeAutomoveis.Nome, automovel.TipoDeCombustivel, automovel.Cor, automovel.KmRodados,foto);
            }
        }
        private void ConfigurarGrid()
        {
            tabelaAutomovel.ConfigurarGridZebrado();

            tabelaAutomovel.ConfigurarGridSomenteLeitura();

            tabelaAutomovel.ConfigurarGridDockFill();

        }
    }
}
