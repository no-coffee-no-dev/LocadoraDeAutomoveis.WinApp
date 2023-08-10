using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    public class ConfigurarTooltipFuncionario : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Funcionário";

        public override string TooltipInserir => "Inserir um novo Funcionário";

        public override string TooltipEditar => "Editar um Funcionário existente";

        public override string TooltipExcluir => "Excluir um Funcionário existente";
    }
}
