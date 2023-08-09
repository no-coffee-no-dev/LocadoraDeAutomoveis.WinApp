using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
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

namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaFuncionario.Columns.AddRange(ObterColunas());
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
                    Name = "Admissao",
                    HeaderText = "Admissao"
                },

                 new DataGridViewTextBoxColumn
                {
                    Name = "Salario",
                    HeaderText = "Salario"
                },


            };

            return colunas;
        }
        public Guid? ObtemIdSelecionado()
        {
            return tabelaFuncionario.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            tabelaFuncionario.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                tabelaFuncionario.Rows.Add(funcionario.Id, funcionario.nome, funcionario.admissao, funcionario.salario);
            }
        }


        private void ConfigurarGrid()
        {
            tabelaFuncionario.ConfigurarGridZebrado();

            tabelaFuncionario.ConfigurarGridSomenteLeitura();

            tabelaFuncionario.ConfigurarGridDockFill();

        }
    }

}
