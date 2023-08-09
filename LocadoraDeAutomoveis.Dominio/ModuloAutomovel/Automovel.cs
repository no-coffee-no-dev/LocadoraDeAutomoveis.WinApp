using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAutomovel
{
    public class Automovel : EntidadeBase<Automovel>
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public DateTime Ano { get; set; }
        public int KmRodados { get; set; }
        public GrupoDeAutomoveis GrupoDeAutomoveis { get; set; }
        public int CapacidadeEmLitros { get; set; }
        public byte[] Foto { get; set; }
        public TipoDeCombustivelEnum TipoDeCombustivel { get; set; }


        public Automovel()
        {
            
        }
        public Automovel(Guid id) : this()
        {
            Id = id;
        }

        public Automovel(Guid id, int kmRodados, string modelo, string marca, string cor, string placa, DateTime ano, GrupoDeAutomoveis grupoDeAutomoveis, int capacidadeEmLitros, byte[] foto, TipoDeCombustivelEnum tipoDeCombustivel) : this(id)
        {
            KmRodados = kmRodados;
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            Placa = placa;
            Ano = ano;
            GrupoDeAutomoveis = grupoDeAutomoveis;
            CapacidadeEmLitros = capacidadeEmLitros;
            Foto = foto;
            
        }

        public override void Atualizar(Automovel registro)
        {
            KmRodados = registro.KmRodados;
            Modelo = registro.Modelo;
            Marca = registro.Marca;
            Cor = registro.Cor;
            Placa = registro.Placa;
            Ano = registro.Ano;
            GrupoDeAutomoveis = registro.GrupoDeAutomoveis;
            CapacidadeEmLitros = registro.CapacidadeEmLitros;
            Foto = registro.Foto;
            TipoDeCombustivel = registro.TipoDeCombustivel;
        }


        public override string? ToString()
        {
            return $"{Marca} {Cor}";
        }
    }
}
