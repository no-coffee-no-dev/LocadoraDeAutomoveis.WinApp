using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel : IRepositorio<Aluguel>
    {
        void Finalizar(Aluguel aluguel);
    }
}
