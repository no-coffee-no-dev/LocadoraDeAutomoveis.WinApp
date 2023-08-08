namespace GeradorTestes.WinApp.ModuloCliente
{
    public class ConfigurarTooltipCliente : ConfigurarToolTipBase
    {
        public override string TipoCadastro => "Cadastro de Clientes"; 

        public override string TooltipInserir => "Inserir novo Cliente";

        public override string TooltipEditar => "Editar um Cliente existente";

        public override string TooltipExcluir => "Excluir um Cliente existente";
    }
}