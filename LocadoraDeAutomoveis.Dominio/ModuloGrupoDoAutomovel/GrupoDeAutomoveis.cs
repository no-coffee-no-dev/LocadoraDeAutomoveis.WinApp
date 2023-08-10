using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel
{
    public class GrupoDeAutomoveis : EntidadeBase<GrupoDeAutomoveis>
    {
        public string Nome { get; set; }
        //public PlanoDeCobranca plano;

        public GrupoDeAutomoveis()
        {
        }
        public GrupoDeAutomoveis(Guid id) : this()
        {
            Id = id;
        }
        public GrupoDeAutomoveis(Guid id, string nome) : this(id)
        {
            Nome = nome;
        }
        public override void Atualizar(GrupoDeAutomoveis registro)
        {
            Nome = registro.Nome;
        }


        public override string? ToString()
        {
            return $"{Nome}";
        }
    }
}
