using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using Microsoft.Data.SqlClient;
using Serilog;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloPlanoDeCobranca
{
    public class ServicoPlanoDeCobranca
    {
        private IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;
        private IValidadorPlanoDeCobranca validadorPlanoDeCobranca;

        public ServicoPlanoDeCobranca(IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca, IValidadorPlanoDeCobranca validadorPlanoDeCobranca)
        {
            this.repositorioPlanoDeCobranca = repositorioPlanoDeCobranca;
            this.validadorPlanoDeCobranca = validadorPlanoDeCobranca;
        }

        public Result Inserir(PlanoDeCobranca planoDeCobranca)
        {
            Log.Debug("Tentando inserir Plano De Cobranca...{@p}", planoDeCobranca);

            List<string> erros = ValidarPlanoDeCobranca(planoDeCobranca);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioPlanoDeCobranca.Inserir(planoDeCobranca);

                Log.Debug("Plano De Cobranca {PlanoDeCobrancaId} inserido com sucesso", planoDeCobranca.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Plano De Cobranca.";

                Log.Error(exc, msgErro + "{@p}", planoDeCobranca);

                return Result.Fail(msgErro); //cenário 3
            }
        }




        public Result Atualizar(PlanoDeCobranca planoDeCobranca)
        {
            Log.Debug("Tentando editar Plano De Cobranca...{@p}", planoDeCobranca);

            List<string> erros = ValidarPlanoDeCobranca(planoDeCobranca);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioPlanoDeCobranca.Atualizar(planoDeCobranca);

                Log.Debug("PlanoDeCobranca {PlanoDeCobrancaId} editada com sucesso", planoDeCobranca.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Plano De Cobranca.";

                Log.Error(exc, msgErro + "{@p}", planoDeCobranca);

                return Result.Fail(msgErro);
            }
        }




        public Result Excluir(PlanoDeCobranca planoDeCobranca)
        {
            Log.Debug("Tentando excluir Plano De Cobranca...{@p}", planoDeCobranca);

            try
            {
                bool parceiroExiste = repositorioPlanoDeCobranca.Existe(planoDeCobranca);

                if (parceiroExiste == false)
                {
                    Log.Warning("PlanoDeCobranca {PlanoDeCobrancaId} não encontrada para excluir", planoDeCobranca.Id);

                    return Result.Fail("Plano De Cobranca não encontrada");
                }

                repositorioPlanoDeCobranca.Deletar(planoDeCobranca);

                Log.Debug("PlanoDeCobranca {PlanoDeCobrancaId} excluída com sucesso", planoDeCobranca.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBPlanoDeCobranca_TBGrupoDeAutomoveis"))
                    msgErro = "Esta Plano De Cobranca está relacionado com um Grupo De Automoveis e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir Plano De Cobranca";
                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {PlanoDeCobrancaId}", planoDeCobranca.Id);

                return Result.Fail(erros);
            }
        }











































        private bool PlanoDuplicado(PlanoDeCobranca planoDeCobranca)
        {
            PlanoDeCobranca planoDeCobrancaEncontrado = repositorioPlanoDeCobranca.Busca(planoDeCobranca.Id);

            if (planoDeCobrancaEncontrado != null &&
                planoDeCobrancaEncontrado.Id != planoDeCobranca.Id &&
                planoDeCobrancaEncontrado.PrecoDaDiaria == planoDeCobranca.PrecoDaDiaria &&
                planoDeCobrancaEncontrado.KmDisponiveis == planoDeCobranca.KmDisponiveis &&
                planoDeCobrancaEncontrado.PrecoPorKM == planoDeCobranca.PrecoPorKM &&
                planoDeCobrancaEncontrado.TipoDePlano == planoDeCobranca.TipoDePlano)
            {
                return true;
            }

            return false;
        }

        private List<string> ValidarPlanoDeCobranca(PlanoDeCobranca planoDeCobranca)
        {
            var resultadoValidacao = validadorPlanoDeCobranca.Validate(planoDeCobranca);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (PlanoDuplicado(planoDeCobranca))
                erros.Add($"Este nome '{planoDeCobranca.TipoDePlano}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
