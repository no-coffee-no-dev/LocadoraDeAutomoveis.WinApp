using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public interface IContextoPersistencia // Unit of Work - UoW
    {
        void DesfazerAlteracoes();

        void GravarDados();
    }
}
