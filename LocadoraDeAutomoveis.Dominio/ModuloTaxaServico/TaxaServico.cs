using LocadoraDeAutomoveis.Dominio.Compartilhado;

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

        public override void Atualizar(TaxaServico registro)
        {
            throw new NotImplementedException();
        }
    }
}
