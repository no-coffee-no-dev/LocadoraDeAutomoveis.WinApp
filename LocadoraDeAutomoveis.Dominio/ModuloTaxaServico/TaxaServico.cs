using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using System.Reflection.Metadata.Ecma335;
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

        internal decimal CalcularValor(DateTime dataDaPrevistaDevolucao)
        {
            int dias = dataDaPrevistaDevolucao.DayOfYear - DateTime.UtcNow.DayOfYear;
            if (PlanoDeCalculo == EnumPlanoDeCalculo.PRECO_FIXO)
            {
                return (decimal)Preco;
            }
            if (PlanoDeCalculo == EnumPlanoDeCalculo.COBRANCA_DIARIA)
            {
                return (decimal)(Preco * dias);
            }
            return 0;
        }
    }
}
