using LocadoraDeAutomoveis.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloParceiro
{
    public class Parceiro : EntidadeBase<Parceiro>
    {
        public string Nome { get; set; }

        public Parceiro()
        {

        }
        public Parceiro(string Nome) : this()
        {
            this.Nome = Nome;
        }

        public Parceiro (Guid id, string nome) : this(nome)
        {
            Id = id;
        }


        public override void Atualizar(Parceiro registro)
        {
            Nome = registro.Nome;
        }

    }
}
