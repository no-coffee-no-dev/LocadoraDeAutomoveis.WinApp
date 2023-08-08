
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;

namespace LocadoraDeAutomoveis.Dominio.ModuloCliente
{
    public enum EnumTipoCliente
    {
        PessoaFisica = 0,
        PessoaJuridica = 1,
    }
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string CNH { get; set; }
        public string RG { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

        public EnumTipoCliente TipoCliente { get; set; }

        public override void Atualizar(Cliente registro)
        {
            throw new NotImplementedException();
        }
    }
}

//ublic interface IRepositorioDisciplina : IRepositorio<Disciplina>
//{
//Disciplina SelecionarPorNome(string nome);
//List<Disciplina> SelecionarTodos(bool incluirMaterias = false, bool incluirQuestoes = false);
//}
//}