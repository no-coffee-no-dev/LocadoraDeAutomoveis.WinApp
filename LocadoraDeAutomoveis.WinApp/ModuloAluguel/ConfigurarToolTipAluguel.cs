using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloAluguel
{
    public class ConfigurarToolTipAluguel : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Alugueis";

        public override string TooltipInserir => "Inserir novo Aluguel";

        public override string TooltipEditar => "Editar um Aluguel existente";

        public override string TooltipExcluir => "Excluir um Aluguel existente";
    }
}
