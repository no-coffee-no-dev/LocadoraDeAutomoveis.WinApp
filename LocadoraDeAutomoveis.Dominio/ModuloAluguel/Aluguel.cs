using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public decimal ValorFinal { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public GrupoDeAutomoveis GrupoDeAutomoveis { get; set; }
        public DateTime DataDoAluguel { get; set; }
        public Condutor Condutor { get; set; }
        public Automovel Automovel { get; set; }
        public DateTime DataDaPrevistaDevolucao { get; set; }
        public PlanoDeCobranca PlanoDeCobranca { get; set; }
        public Cupom? Cupom { get; set; }
        public List<TaxaServico> TaxasEServicos { get; set; }

        public Aluguel()
        {

        }
        public Aluguel(Guid id) : this()
        {
            Id = id;
        }

        public Aluguel(Guid id,decimal valorFinal, Funcionario funcionario, Cliente cliente, GrupoDeAutomoveis grupoDeAutomoveis, DateTime dataDoAluguel, Condutor condutor, Automovel automovel, DateTime dataDaPrevistaDevolucao, PlanoDeCobranca planoDeCobranca, Cupom? cupom, List<TaxaServico> taxasEServicos) : this(id)
        {
            ValorFinal = valorFinal;
            Funcionario = funcionario;
            Cliente = cliente;
            GrupoDeAutomoveis = grupoDeAutomoveis;
            DataDoAluguel = dataDoAluguel;
            Condutor = condutor;
            Automovel = automovel;
            DataDaPrevistaDevolucao = dataDaPrevistaDevolucao;
            PlanoDeCobranca = planoDeCobranca;
            Cupom = cupom;
            TaxasEServicos = taxasEServicos;
        }

        public override void Atualizar(Aluguel registro)
        {
            ValorFinal = registro.ValorFinal;
            Cliente = registro.Cliente;
            Condutor = registro.Condutor;
            Funcionario = registro.Funcionario;
            TaxasEServicos = registro.TaxasEServicos;
            PlanoDeCobranca = registro.PlanoDeCobranca;
            GrupoDeAutomoveis = registro.GrupoDeAutomoveis;
            DataDoAluguel = registro.DataDoAluguel;
            Automovel = registro.Automovel;
            DataDaPrevistaDevolucao = registro.DataDaPrevistaDevolucao;
            Cupom = registro.Cupom;
        }

        public decimal CalcularValorComCupom()
        {         
            if (Cupom.Expirado != true)
                return ValorFinal -= Cupom.Valor;
            else
                return 0;
        }

        public override string? ToString()
        {
            return $"Aluguel do Carro{Automovel.Marca}  {Automovel.Cor}";
        }

        public decimal CalcularValorFinal()
        {
            return 100;
        }
    }
}
