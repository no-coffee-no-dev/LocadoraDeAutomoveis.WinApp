using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel
{
    public class ConfigurarToolTipGrupoDeAutomoveis : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Grupo de Automoveis";

        public override string TooltipInserir => "Inserir novo Grupo de Automovel";

        public override string TooltipEditar => "Editar um Grupo de Automovel existente";

        public override string TooltipExcluir => "Excluir um Grupo de Automovel existente";
    }
}
