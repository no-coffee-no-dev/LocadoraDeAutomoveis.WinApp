using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloCondutor
{   
    public enum enumTipoCondutor
    {
        ClienteCondutor = 0,
        ApenasCondutor = 1,
    }
    public class Condutor : EntidadeBase<Condutor>
    {
        public Cliente cliente;
        public string nome {  get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public DateTime validadeCNH { get; set; }
        public enumTipoCondutor tipoCondutor { get; set; }

    

        public Condutor(Cliente cliente)
        {
            this.cliente = cliente;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.CPF = CPF;
            this.CNH = CNH;
            this.validadeCNH = validadeCNH;
            this.tipoCondutor = tipoCondutor;
        }

        public override void Atualizar(Condutor registro)
        {
            cliente = registro.cliente;
            nome = registro.nome;
            email = registro.email;
            telefone = registro.telefone;
            CPF = registro.CPF;
            CNH = registro.CNH;
            validadeCNH = registro.validadeCNH;
            tipoCondutor = registro.tipoCondutor;

        }
    }
}
