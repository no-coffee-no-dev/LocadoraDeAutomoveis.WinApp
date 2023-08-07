using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca
{
    public class ConfigurarToolTipPlanoDeCobranca : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Planos de Cobranca";

        public override string TooltipInserir => "Inserir novo Plano de Cobranca";

        public override string TooltipEditar => "Editar um Plano de Cobranca existente";

        public override string TooltipExcluir => "Excluir um Plano de Cobranca existente";
    }
}
