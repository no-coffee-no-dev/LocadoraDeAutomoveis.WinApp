using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.Compartilhado.IoC
{
    public interface IoC
    {
        T Get<T>();
    }
}
