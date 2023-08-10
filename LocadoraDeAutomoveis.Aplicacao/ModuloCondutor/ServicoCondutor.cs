using FluentResults;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloCondutor
{
    public class ServicoCondutor
    {
        private IRepositorioCondutor repositorioCondutor;
        private IValidadorCondutor validadorCondutor;
        private IContextoPersistencia contextoPersistencia;

        public ServicoCondutor(IRepositorioCondutor repositorioCondutor, IValidadorCondutor validadorCondutor, IContextoPersistencia contextoPersistencia)
        {
            this.repositorioCondutor = repositorioCondutor;
            this.validadorCondutor = validadorCondutor;
            this.contextoPersistencia = contextoPersistencia;
        }

        public Result Inserir(Condutor Condutor)
        {
            Log.Debug("Tentando inserir Condutor...{@c}", Condutor);

            List<string> erros = ValidarCondutor(Condutor);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();
                return Result.Fail(erros);
            }
            try
            {
                repositorioCondutor.Inserir(Condutor);

                contextoPersistencia.GravarDados();

                Log.Debug("Condutor {CondutorId} inserido com sucesso", Condutor.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Condutor.";

                Log.Error(exc, msgErro + "{@c}", Condutor);

                return Result.Fail(msgErro);
            }
        }

        public Result Atualizar(Condutor Condutor)
        {
            Log.Debug("Tentando editar Condutor...{@c}", Condutor);

            List<string> erros = ValidarCondutor(Condutor);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();
                return Result.Fail(erros);
            }
            try
            {
                repositorioCondutor.Atualizar(Condutor);

                contextoPersistencia.GravarDados();

                Log.Debug("Condutor {CondutorId} editado com sucesso", Condutor.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Condutor.";

                Log.Error(exc, msgErro + "{@c}", Condutor);

                return Result.Fail(msgErro);
            }
        }
        public Result Excluir(Condutor Condutor)
        {
            Log.Debug("Tentando excluir Condutor...{@c}", Condutor);

            try
            {
                bool CondutorExiste = repositorioCondutor.Existe(Condutor);

                if (CondutorExiste == false)
                {
                    Log.Warning("Condutor {CondutorId} não encontrado para excluir", Condutor.Id);

                    return Result.Fail("Condutor não encontrado");
                }

                repositorioCondutor.Deletar(Condutor);

                contextoPersistencia.GravarDados();

                Log.Debug("Condutor {CondutorID} excluído com sucesso", Condutor.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                List<string> erros = new List<string>();

                string msgErro = "não foi possivel deletar o Condutor";

                Log.Error(ex, msgErro + " {CondutorId}", Condutor.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarCondutor(Condutor Condutor)
        {
            var resultadoValidacao = validadorCondutor.Validate(Condutor);

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
