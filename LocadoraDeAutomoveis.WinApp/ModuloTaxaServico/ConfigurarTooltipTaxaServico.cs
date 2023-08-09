using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloTaxaServico
{
    public class ConfigurarTooltipTaxaServico : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Taxa de Serviço";

        public override string TooltipInserir => "Inserir nova Taxa de Serviço";

        public override string TooltipEditar => "Editar uma Taxa de Serviço existente";

        public override string TooltipExcluir => "Excluir uma Taxa de Serviço existente";
    }
}