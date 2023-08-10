using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string nome {get; set;}
        public DateTime admissao { get; set;}
        public decimal salario { get; set;}


        public override void Atualizar(Funcionario registro)
        {
            nome = registro.nome;
            admissao = registro.admissao;
            salario = registro.salario;
        }
        public override string? ToString()
        {
            return base.ToString();
        }
    }

}
