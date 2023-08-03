using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloCupom
{
    public class ServicoCupom
    {
        private IRepositorioCupom repositorioCupom;
        private IValidadorCupom validadorCupom;

        public ServicoCupom(IRepositorioCupom repositorioCupom, IValidadorCupom validadorCupom)
        {

            this.repositorioCupom = repositorioCupom;
            this.validadorCupom = validadorCupom;

        }


        public Result Inserir(Cupom cupom)
        {
            Log.Debug("Tentando inserir cupom...{@c}", cupom);

            List<string> erros = ValidarCupom(cupom);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioCupom.Inserir(cupom);

                Log.Debug("Cupom {CupomId} inserido com sucesso", cupom.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir parceiro.";

                Log.Error(exc, msgErro + "{@c}", cupom);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Atualizar(Cupom cupom)
        {
            Log.Debug("Tentando editar cupom...{@c}", cupom);

            List<string> erros = ValidarCupom(cupom);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCupom.Atualizar(cupom);

                Log.Debug("Cupom {CupomId} editado com sucesso", cupom.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Cupom.";

                Log.Error(exc, msgErro + "{@c}", cupom);

                return Result.Fail(msgErro);
            }
        }




        public Result Excluir(Cupom cupom)
        {
            Log.Debug("Tentando excluir cupom...{@c}", cupom);

            try
            {
                bool cupomExiste = repositorioCupom.Existe(cupom);

                if (cupomExiste == false)
                {
                    Log.Warning("Cupom {CupomId} não encontrada para excluir", cupom.Id);

                    return Result.Fail("Cupom não encontrado");
                }

                repositorioCupom.Deletar(cupom);

                Log.Debug("Cupom {CupomId} excluída com sucesso", cupom.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBCupom_TBParceiro"))
                    msgErro = "Esta cupom está relacionado com um parceiro e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir parceiro";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {CupomId}", cupom.Id);

                return Result.Fail(erros);
            }
        }

















        private bool NomeDuplicado(Cupom cupom)
        {
            Cupom cupomEncontrado = repositorioCupom.SelecionarPorNome(cupom.Nome);

            if (cupomEncontrado != null &&
                cupomEncontrado.Id != cupom.Id &&
                cupomEncontrado.Nome == cupom.Nome)
            {
                return true;
            }

            return false;
        }

        private List<string> ValidarCupom(Cupom cupom)
        {
            var resultadoValidacao = validadorCupom.Validate(cupom);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(cupom))
                erros.Add($"Este nome '{cupom.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
