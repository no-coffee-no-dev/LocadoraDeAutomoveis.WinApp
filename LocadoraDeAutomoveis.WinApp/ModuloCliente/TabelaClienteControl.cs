using LocadoraDeAutomoveis.Dominio.ModuloCliente;

namespace LocadoraDeAutomoveis.WinApp.ModuloCliente
{
    public partial class TabelaCliente : UserControl
    {
        public TabelaCliente()
        {
            InitializeComponent();
            ConfigurarGrid();
            tabelaClientes.Columns.AddRange(ObterColunas());
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
                    Name = "CPF",
                    HeaderText = "CPF"
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "CNPJ",
                    HeaderText = "CNPJ"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Estado",
                    HeaderText = "Estado"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Cidade",
                    HeaderText = "Cidade"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Bairro",
                    HeaderText = "Bairro"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Rua",
                    HeaderText = "Rua"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Numero",
                    HeaderText = "Numero"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "RG",
                    HeaderText = "RG"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "CNH",
                    HeaderText = "CNH"
                },
            };

            return colunas;
        }
        public Guid ObtemIdSelecionado()
        {
            return tabelaClientes.ObterIDdoGrid();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            tabelaClientes.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                tabelaClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.Telefone, cliente.CPF, cliente.CNPJ, cliente.Estado, cliente.Cidade, cliente.Bairro, cliente.Rua, cliente.Numero, cliente.RG, cliente.CNH);
            }
        }

        private void ConfigurarGrid()
        {
            tabelaClientes.ConfigurarGridZebrado();

            tabelaClientes.ConfigurarGridSomenteLeitura();

            tabelaClientes.ConfigurarGridDockFill();

        }
    }
}
