using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloParceiro
{
    public class ConfigurarToolTipParceiro : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Parceiros";

        public override string TooltipInserir => "Inserir novo Parceiros";

        public override string TooltipEditar => "Editar um Parceiros existente";

        public override string TooltipExcluir => "Excluir um Parceiros existente";
    }
}
