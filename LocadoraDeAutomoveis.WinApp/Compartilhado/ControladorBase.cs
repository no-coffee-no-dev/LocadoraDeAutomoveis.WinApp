﻿namespace LocadoraDeAutomoveis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        protected string stringRodape;
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Deletar();
        public virtual void Filtrar() { }
        public virtual void GerarPdf() { }
        public virtual void VisualizarItem() { }
        public virtual void FinalizarAluguel() { }
        public abstract UserControl ObterListagem();
        public virtual void ConfigurarDesconto() { }
        public abstract ConfigurarToolTipBase ObtemConfiguracaoTooltip();
        public abstract string ObterTipoCadastro();
        public abstract void CarregarEntidades(); 
        public string ObterStringRodape()
        {
            return stringRodape;
        }
    }
}
