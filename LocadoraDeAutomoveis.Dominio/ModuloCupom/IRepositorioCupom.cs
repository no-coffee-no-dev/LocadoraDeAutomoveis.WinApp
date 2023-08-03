using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloCupom
{
    public interface IRepositorioCupom : IRepositorio<Cupom>
    {
        Cupom SelecionarPorNome(string nome);
    }
}
