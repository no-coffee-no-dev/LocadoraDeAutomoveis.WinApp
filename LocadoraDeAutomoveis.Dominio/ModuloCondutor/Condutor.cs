using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public Cliente Cliente {  get; set; }
        public string Nome {  get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public DateTime ValidadeCNH { get; set; }
        public enumTipoCondutor TipoCondutor { get; set; }

        public Condutor()
        {
        }

        public Condutor(Guid id) : this()
        {
            Id = id;
        }
        public Condutor(Guid id, Cliente cliente, string nome, string email, string telefone, string cPF, string cNH, DateTime validadeCNH, enumTipoCondutor tipoCondutor) : this(id)
        {
            Cliente = cliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cPF;
            CNH = cNH;
            ValidadeCNH = validadeCNH;
            TipoCondutor = tipoCondutor;
        }

        public override void Atualizar(Condutor registro)
        {
            Cliente = registro.Cliente;
            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            CPF = registro.CPF;
            CNH = registro.CNH;
            ValidadeCNH = registro.ValidadeCNH;
            TipoCondutor = registro.TipoCondutor;

        }

        public override string? ToString()
        {
            return $"{Nome}";
        }
    }
}
