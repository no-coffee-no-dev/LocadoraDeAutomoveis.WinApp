﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloCupom
{
    public class ConfigurarToolTipCupom : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Cupons";

        public override string TooltipInserir => "Inserir novo Cupons";

        public override string TooltipEditar => "Editar um Cupom existente";

        public override string TooltipExcluir => "Excluir um Cupom existente";
    }
}
