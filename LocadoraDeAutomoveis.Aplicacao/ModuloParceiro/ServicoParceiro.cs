﻿using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloParceiro
{
    public class ServicoParceiro
    {
        private IRepositorioParceiro repositorioParceiro;
        private IValidadorParceiro validadorParceiro;

        public ServicoParceiro(IRepositorioParceiro repositorioParceiro, IValidadorParceiro validadorParceiro)
        {

            this.repositorioParceiro = repositorioParceiro;
            this.validadorParceiro = validadorParceiro;

        }


        public Result Inserir(Parceiro parceiro)
        {
            Log.Debug("Tentando inserir parceiro...{@d}", parceiro);

            List<string> erros = ValidarParceiro(parceiro);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioParceiro.Inserir(parceiro);

                Log.Debug("Parceiro {ParceiroId} inserida com sucesso", parceiro.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir parceiro.";

                Log.Error(exc, msgErro + "{@d}", parceiro);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Atualizar(Parceiro parceiro)
        {
            Log.Debug("Tentando editar parceiro...{@d}", parceiro);

            List<string> erros = ValidarParceiro(parceiro);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioParceiro.Atualizar(parceiro);

                Log.Debug("Parceiro {ParceiroId} editada com sucesso", parceiro.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar parceiro.";

                Log.Error(exc, msgErro + "{@d}", parceiro);

                return Result.Fail(msgErro);
            }
        }




        public Result Excluir(Parceiro parceiro)
        {
            Log.Debug("Tentando excluir parceiro...{@d}", parceiro);

            try
            {
                bool parceiroExiste = repositorioParceiro.Existe(parceiro);

                if (parceiroExiste == false)
                {
                    Log.Warning("Parceiro {ParceiroId} não encontrada para excluir", parceiro.Id);

                    return Result.Fail("Parceiro não encontrada");
                }

                repositorioParceiro.Deletar(parceiro);

                Log.Debug("Parceiro {ParceiroId} excluída com sucesso", parceiro.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                msgErro = "Falha ao tentar excluir parceiro";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {ParceiroId}", parceiro.Id);

                return Result.Fail(erros);
            }
        }

















        private bool NomeDuplicado(Parceiro parceiro)
        {
            Parceiro parceiroEncontrado = repositorioParceiro.SelecionarPorNome(parceiro.Nome);

            if (parceiroEncontrado != null &&
                parceiroEncontrado.Id != parceiro.Id &&
                parceiroEncontrado.Nome == parceiro.Nome)
            {
                return true;
            }

            return false;
        }

        private List<string> ValidarParceiro(Parceiro parceiro)
        {
            var resultadoValidacao = validadorParceiro.Validate(parceiro);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(parceiro))
                erros.Add($"Este nome '{parceiro.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }

}
