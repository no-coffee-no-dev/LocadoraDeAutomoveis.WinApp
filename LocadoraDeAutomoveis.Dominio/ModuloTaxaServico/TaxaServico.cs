using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using System.Security.Cryptography;

namespace LocadoraDeAutomoveis.Dominio.ModuloTaxaServico
{
    public enum EnumPlanoDeCalculo
    {
        PRECO_FIXO = 0,
        COBRANCA_DIARIA = 1
    }
    public class TaxaServico : EntidadeBase<TaxaServico>
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public EnumPlanoDeCalculo PlanoDeCalculo { get; set; }

        public TaxaServico()
        {

        }
        public TaxaServico(Guid id) : this()
        {
            Id = id;
        }

        public TaxaServico(Guid id,string nome, double preco, EnumPlanoDeCalculo planoDeCalculo) : this(id)
        {
            Nome = nome;
            Preco = preco;
            PlanoDeCalculo = planoDeCalculo;
        }

        public override void Atualizar(TaxaServico registro)
        {
            Nome = registro.Nome;
            Preco = registro.Preco;
            PlanoDeCalculo = registro.PlanoDeCalculo;
        }

        public override string? ToString()
        {
            return $"{Nome}";
        }
    }
}
