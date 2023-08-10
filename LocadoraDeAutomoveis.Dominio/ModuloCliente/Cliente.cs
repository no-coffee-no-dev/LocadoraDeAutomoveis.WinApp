namespace LocadoraDeAutomoveis.Dominio.ModuloCliente
{
    public enum EnumTipoCliente
    {
        PessoaFisica = 0,
        PessoaJuridica = 1,
    }
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string CNH { get; set; }
        public string RG { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

        public EnumTipoCliente TipoCliente { get; set; }

        public Cliente()
        {

        }
        public Cliente(Guid id) : this()
        {
            Id = id;
        }
        public Cliente(Guid id,string nome, string email, string telefone, string cPF, string cNPJ, string cNH, string rG, string estado, string cidade, string bairro, string rua, string numero, EnumTipoCliente tipoCliente) : this(id)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cPF;
            CNPJ = cNPJ;
            CNH = cNH;
            RG = rG;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            TipoCliente = tipoCliente;
        }

        public override void Atualizar(Cliente registro)
        {
            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            CPF = registro.CPF;
            CNPJ = registro.CNPJ;
            CNH = registro.CNH;
            RG = registro.RG;
            Estado = registro.Estado;
            Cidade = registro.Cidade;
            Bairro = registro.Bairro;
            Rua = registro.Rua;
            Numero = registro.Numero;
            TipoCliente = registro.TipoCliente;
        }

        public override string? ToString()
        {
            return $"{Nome}";
        }
    }
}
