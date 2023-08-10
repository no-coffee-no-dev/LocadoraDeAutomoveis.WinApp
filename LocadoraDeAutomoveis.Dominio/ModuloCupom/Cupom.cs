using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloCupom
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public string Nome { get; set; }
        public Parceiro Parceiro { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDeValidade { get; set; }
        public bool Expirado { get; set; }

        public Cupom()
        {

        }
        public Cupom(Guid id) : this()
        {
            Id = id;
        }

        public Cupom(Guid id,string nome, Parceiro parceiro, decimal valor, DateTime dataDeValidade) : this(id)
        {
            Nome = nome;
            Parceiro = parceiro;
            Valor = valor;
            DataDeValidade = dataDeValidade;
            Expirado = false;
        }

        public override void Atualizar(Cupom registro)
        {
            Nome = registro.Nome;
            Parceiro = registro.Parceiro;
            Valor = registro.Valor;
            DataDeValidade = registro.DataDeValidade;
        }

        public void Expirou()
        {
            if (DataDeValidade < DateTime.UtcNow.Date)
            {
                this.Expirado = true;
            }
            else
                this.Expirado = false;
        }

        public override string? ToString()
        {
            return $"{Nome}";
        }

        internal decimal? Descontar(decimal? valorTotal)
        {
            return valorTotal - Valor;
        }
    }
}