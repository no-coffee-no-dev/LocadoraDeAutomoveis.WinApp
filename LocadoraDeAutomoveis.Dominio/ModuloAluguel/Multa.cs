using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAluguel
{
    public class Multa : EntidadeBase<Multa>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public override void Atualizar(Multa registro)
        {
            throw new NotImplementedException();
        }
    }
}
