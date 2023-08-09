using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using Microsoft.Data.SqlClient;
using Serilog;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloCliente
{
    public class ServicoCliente
    {
        private IRepositorioCliente repositorioCliente;
        private IValidadorCliente validadorCliente;

        public ServicoCliente(IRepositorioCliente repositorioCliente, IValidadorCliente validadorCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.validadorCliente = validadorCliente;
        }


        public Result Inserir(Cliente cliente)
        {
            Log.Debug("Tentando inserir Cliente...{@c}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioCliente.Inserir(cliente);

                Log.Debug("Cliente {ClienteId} inserido com sucesso", cliente.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir cliente.";

                Log.Error(exc, msgErro + "{@c}", cliente);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Atualizar(Cliente cliente)
        {
            Log.Debug("Tentando editar Cliente...{@c}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCliente.Atualizar(cliente);

                Log.Debug("Cliente {ClienteId} editado com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Cliente.";

                Log.Error(exc, msgErro + "{@c}", cliente);

                return Result.Fail(msgErro);
            }
        }


        public Result Excluir(Cliente cliente)
        {
            Log.Debug("Tentando excluir Cliente...{@c}", cliente);

            try
            {
                bool ClienteExiste = repositorioCliente.Existe(cliente);

                if (ClienteExiste == false)
                {
                    Log.Warning("Cliente {ClienteId} não encontrada para excluir", cliente.Id);

                    return Result.Fail("Cliente não encontrado");
                }

                repositorioCliente.Deletar(cliente);

                Log.Debug("Cliente {ClienteId} excluída com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro = "não foi possivel deletar o cliente";

                Log.Error(ex, msgErro + " {ClienteId}", cliente.Id);

                return Result.Fail(erros);
            }
        }

        //private bool CpfDuplicado(Cliente Cliente)
        //{
        //    Cliente ClienteEncontrado = repositorioCliente.SelecionarPorNome(Cliente.Nome);

        //    if (ClienteEncontrado != null &&
        //        ClienteEncontrado.Id != Cliente.Id &&
        //        ClienteEncontrado.Nome == Cliente.Nome)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        private List<string> ValidarCliente(Cliente Cliente)
        {
            var resultadoValidacao = validadorCliente.Validate(Cliente);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            //if (CpfDuplicado(Cliente))
            //    erros.Add($"Este nome '{Cliente.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}