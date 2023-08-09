using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
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

namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    public partial class TelaFiltroGrupoDeAutomoveis : Form
    {
        IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        public GrupoDeAutomoveis grupoDeAutomoveis;
        public TelaFiltroGrupoDeAutomoveis(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            ConfigurarTabelaDeGrupos(repositorioGrupoDeAutomoveis);
        }

        private void ConfigurarTabelaDeGrupos(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            List<GrupoDeAutomoveis> listaDeGrupos = repositorioGrupoDeAutomoveis.RetornarTodos();
            tabelaGrupoDeAutomoveis.AtualizarRegistros(listaDeGrupos);
        }

        public GrupoDeAutomoveis ObterGrupoParaFiltro()
        {
            Guid? id = tabelaGrupoDeAutomoveis.ObtemIdSelecionado();
            GrupoDeAutomoveis grupoDeAutomoveis = repositorioGrupoDeAutomoveis.Busca(id);
            return grupoDeAutomoveis;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            grupoDeAutomoveis = ObterGrupoParaFiltro();
        }
    }
}
