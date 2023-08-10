using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    public partial class TabelaCondutorControl : UserControl
    {
        public TabelaCondutorControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaCondutor.Columns.AddRange(ObterColunas());
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
                    Name = "Cliente",
                    HeaderText = "Cliente"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Nome",
                    HeaderText = "Nome"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Email",
                    HeaderText = "Email"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Telefone",
                    HeaderText = "Telefone"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Telefone",
                    HeaderText = "Telefone"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "CPF",
                    HeaderText = "CPF"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "CNH",
                    HeaderText = "CNH"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Validade",
                    HeaderText = "Validade"
                },

            };

            return colunas;
        }

        public Guid? ObtemIdSelecionado()
        {
            return tabelaCondutor.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Condutor> condutores)
        {
            tabelaCondutor.Rows.Clear();

            foreach (Condutor condutor in condutores)
            {
                tabelaCondutor.Rows.Add(condutor.Id, condutor.cliente, condutor.nome, condutor.email,condutor.telefone,condutor.CPF,condutor.CNH,condutor.validadeCNH);
            }
        }

        private void ConfigurarGrid()
        {
            tabelaCondutor.ConfigurarGridZebrado();

            tabelaCondutor.ConfigurarGridSomenteLeitura();

            tabelaCondutor.ConfigurarGridDockFill();

        }
    }

}
