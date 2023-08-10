using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloCondutor
{
    public class ConfigurarTooltipCondutor : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Condutor";

        public override string TooltipInserir => "Inserir novo Condutor";

        public override string TooltipEditar => "Editar um Condutor existente";

        public override string TooltipExcluir => "Excluir um Condutor existente";
    }
}
