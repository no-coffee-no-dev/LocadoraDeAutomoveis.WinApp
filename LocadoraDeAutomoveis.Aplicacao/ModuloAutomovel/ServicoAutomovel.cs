using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloAutomovel
{
    public class ServicoAutomovel
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private IValidadorAutomovel validadorAutomovel;

        public ServicoAutomovel(IRepositorioAutomovel repositorioAutomovel, IValidadorAutomovel validadorAutomovel)
        {
            this.repositorioAutomovel = repositorioAutomovel;
            this.validadorAutomovel = validadorAutomovel;
        }

        public Result Inserir(Automovel automovel)
        {
            Log.Debug("Tentando inserir automovel...{@a}", automovel);

            List<string> erros = ValidarCupom(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioAutomovel.Inserir(automovel);

                Log.Debug("Automovel {AutomovelId} inserido com sucesso", automovel.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir automovel.";

                Log.Error(exc, msgErro + "{@a}", automovel);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Atualizar(Automovel automovel)
        {
            Log.Debug("Tentando editar automovel...{@a}", automovel);

            List<string> erros = ValidarCupom(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioAutomovel.Atualizar(automovel);

                Log.Debug("Automovel {AutomovelId} editado com sucesso", automovel.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar automovel.";

                Log.Error(exc, msgErro + "{@c}", automovel);

                return Result.Fail(msgErro);
            }
        }




        public Result Excluir(Automovel automovel)
        {
            Log.Debug("Tentando excluir automovel...{@a}", automovel);

            try
            {
                bool cupomExiste = repositorioAutomovel.Existe(automovel);

                if (cupomExiste == false)
                {
                    Log.Warning("Automovel {AutomovelId} não encontrada para excluir", automovel.Id);

                    return Result.Fail("Cupom não encontrado");
                }

                repositorioAutomovel.Deletar(automovel);

                Log.Debug("Automovel {AutomovelId} excluída com sucesso", automovel.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBAutomovel_TBGrupoDeAutoveis"))
                    msgErro = "Esta automovel está relacionado com um grupo de automoveis e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir automovel";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {AutomovelId}", automovel.Id);

                return Result.Fail(erros);
            }
        }








































        private bool AutomovelDuplicado(Automovel automovel)
        {
            Automovel automovelEncontrado = repositorioAutomovel.Busca(automovel.Id);

            if (automovelEncontrado != null &&
                automovelEncontrado.Id != automovelEncontrado.Id &&
                automovelEncontrado.Marca == automovelEncontrado.Marca &&
                automovelEncontrado.Modelo != automovelEncontrado.Modelo &&
                automovelEncontrado.GrupoDeAutomoveis != automovelEncontrado.GrupoDeAutomoveis &&
                automovelEncontrado.Foto != automovelEncontrado.Foto &&
                automovelEncontrado.Cor != automovelEncontrado.Cor)
            {
                return true;
            }

            return false;
        }

        private List<string> ValidarCupom(Automovel automovel)
        {
            var resultadoValidacao = validadorAutomovel.Validate(automovel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (AutomovelDuplicado(automovel))
                erros.Add($"Este nome '{automovel.ToString()}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
