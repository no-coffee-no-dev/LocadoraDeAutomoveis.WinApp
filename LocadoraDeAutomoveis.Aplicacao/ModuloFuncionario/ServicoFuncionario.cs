using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloFuncionario
{
    public class ServicoFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IValidadorFuncionario validadorFuncionario;

        public Result Inserir(Funcionario Funcionario)
        {
            Log.Debug("Tentando inserir Funcionário...{@f}", Funcionario);

            List<string> erros = ValidarFuncionario(Funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros); 

            try
            {
                repositorioFuncionario.Inserir(Funcionario);

                Log.Debug("Cliente {ClienteId} inserido com sucesso", Funcionario.Id);

                return Result.Ok(); 
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Funcionário.";

                Log.Error(exc, msgErro + "{@f}", Funcionario);

                return Result.Fail(msgErro); 
            }
        }

        public Result Atualizar(Funcionario Funcionario)
        {
            Log.Debug("Tentando editar Cliente...{@f}", Funcionario);

            List<string> erros = ValidarFuncionario(Funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioFuncionario.Atualizar(Funcionario);

                Log.Debug("Funcionário {FuncionarioId} editado com sucesso", Funcionario.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Funcionário.";

                Log.Error(exc, msgErro + "{@f}", Funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Funcionario Funcionario)
        {
            Log.Debug("Tentando excluir Funcionário...{@f}", Funcionario);

            try
            {
                bool FuncionarioExiste = repositorioFuncionario.Existe(Funcionario);

                if (FuncionarioExiste == false)
                {
                    Log.Warning("Funcionário {FuncionarioId} não encontrada para excluir", Funcionario.Id);

                    return Result.Fail("Funcionário não encontrado");
                }

                repositorioFuncionario.Deletar(Funcionario);

                Log.Debug("Funcionário {FuncionarioID} excluídO com sucesso", Funcionario.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro = "não foi possivel deletar o Funcinário";

                Log.Error(ex, msgErro + " {FuncionarioId}", Funcionario.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarFuncionario(Funcionario Funcionario)
        {
            var resultadoValidacao = validadorFuncionario.Validate(Funcionario);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));


            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

    }
}
