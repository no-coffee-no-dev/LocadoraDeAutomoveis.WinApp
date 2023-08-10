using FluentResults;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloAluguel
{
    public class ServicoAluguel
    {
        private IRepositorioAluguel repositorioAluguel;
        private IValidadorAluguel validadorAluguel;
        private IContextoPersistencia contextoPersistencia;

        public ServicoAluguel(IRepositorioAluguel repositorioAluguel, IValidadorAluguel validadorAluguel,IContextoPersistencia contextoPersistencia)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.validadorAluguel = validadorAluguel;
            this.contextoPersistencia = contextoPersistencia;
        }

        public Result Inserir(Aluguel aluguel)
        {
            Log.Debug("Tentando inserir aluguel...{@a}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

             if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();

                return Result.Fail(erros);
            }

            try
            {

                repositorioAluguel.Inserir(aluguel);

                contextoPersistencia.GravarDados();

                Log.Debug("Aluguel {AluguelId} inserido com sucesso", aluguel.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir aluguel.";

                Log.Error(exc, msgErro + "{@a}", aluguel);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Finalizar(Aluguel aluguel)
        {
            Log.Debug("Tentando finalizar aluguel...{@a}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();

                return Result.Fail(erros);
            }

            try
            {
                repositorioAluguel.Finalizar(aluguel);

                contextoPersistencia.GravarDados();

                Log.Debug("Aluguel {AluguelId} finalizado com sucesso", aluguel.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar finalizar aluguel.";

                Log.Error(exc, msgErro + "{@a}", aluguel);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Atualizar(Aluguel aluguel)
        {
            Log.Debug("Tentando editar aluguel...{@a}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();

                return Result.Fail(erros);
            }

            try
            {
                repositorioAluguel.Atualizar(aluguel);

                contextoPersistencia.GravarDados();

                Log.Debug("Aluguel {AluguelId} editado com sucesso", aluguel.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar automovel.";

                Log.Error(exc, msgErro + "{@a}", aluguel);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Aluguel aluguel)
        {
            Log.Debug("Tentando excluir aluguel...{@a}", aluguel);

            try
            {
                bool aluguelExiste = repositorioAluguel.Existe(aluguel);

                if (aluguelExiste == false)
                {
                    Log.Warning("Aluguel {AluguelId} não encontrada para excluir", aluguel.Id);

                    return Result.Fail("Cupom não encontrado");
                }

                repositorioAluguel.Deletar(aluguel);

                contextoPersistencia.GravarDados();

                Log.Debug("Aluguel {AluguelId} excluída com sucesso", aluguel.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBAluguel_TBCupom"))
                    msgErro = "Esta aluguel está relacionado com um cupom e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";

                if (ex.Message.Contains("FK_TBAluguel_TBAutomoveis"))
                    msgErro = "Esta aluguel está relacionado com um Automovel e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";

                if (ex.Message.Contains("FK_TBAluguel_TBPlanoDeCobranca"))
                    msgErro = "Esta aluguel está relacionado com um Plano de Cobranca e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";

                if (ex.Message.Contains("FK_TBAluguel_TBCliente"))
                    msgErro = "Esta aluguel está relacionado com um Cliente e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";


                if (ex.Message.Contains("FK_TBAluguel_TBGrupoDeAutoveis"))
                    msgErro = "Esta aluguel está relacionado com um Grupo de Automoveis e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {AluguelId}", aluguel.Id);

                return Result.Fail(erros);
        
            }
        }











































        private bool AluguelDuplicado(Aluguel aluguel)
        {
            Aluguel aluguelEncontrado = repositorioAluguel.Busca(aluguel.Id);

            //if (aluguelEncontrado != null &&
            //    aluguelEncontrado.Id != aluguelEncontrado.Id &&
            //    aluguelEncontrado.a == automovelEncontrado.Marca &&
            //    automovelEncontrado.Modelo != automovelEncontrado.Modelo &&
            //    automovelEncontrado.GrupoDeAutomoveis != automovelEncontrado.GrupoDeAutomoveis &&
            //    automovelEncontrado.Foto != automovelEncontrado.Foto &&
            //    automovelEncontrado.Cor != automovelEncontrado.Cor)
            //{
            //    return true;
            //}

            return false;
        }

        private List<string> ValidarAluguel(Aluguel aluguel)
        {
            var resultadoValidacao = validadorAluguel.Validate(aluguel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (AluguelDuplicado(aluguel))
                erros.Add($"Este nome '{aluguel.ToString()}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
