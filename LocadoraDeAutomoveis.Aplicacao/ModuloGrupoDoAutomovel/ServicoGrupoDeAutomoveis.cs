using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloGrupoDoAutomovel
{
    public class ServicoGrupoDeAutomoveis 
    {

        private IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        private IValidadorGrupoDeAutomoveis validadorGrupoDeAutomoveis;

        public ServicoGrupoDeAutomoveis(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis, IValidadorGrupoDeAutomoveis validadorGrupoDeAutomoveis)
        {

            this.repositorioGrupoDeAutomoveis = repositorioGrupoDeAutomoveis;
            this.validadorGrupoDeAutomoveis = validadorGrupoDeAutomoveis;

        }


        public Result Inserir(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            Log.Debug("Tentando inserir o grupo de automoveis...{@g}", grupoDeAutomoveis);

            List<string> erros = ValidarGrupoDeAutomoveis(grupoDeAutomoveis);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioGrupoDeAutomoveis.Inserir(grupoDeAutomoveis);

                Log.Debug("Grupo de Automoveis {GpDeAutomoveisId} inserido com sucesso", grupoDeAutomoveis.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Grupo de Automoveis.";

                Log.Error(exc, msgErro + "{@g}", grupoDeAutomoveis);

                return Result.Fail(msgErro); //cenário 3
            }
        }






        public Result Atualizar(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            Log.Debug("Tentando editar grupo de automoveis..{@g}", grupoDeAutomoveis);

            List<string> erros = ValidarGrupoDeAutomoveis(grupoDeAutomoveis);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioGrupoDeAutomoveis.Atualizar(grupoDeAutomoveis);

                Log.Debug("Grupo de Automoveis {GpDeAutomoveisId} editado com sucesso", grupoDeAutomoveis.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Grupo de Automoveis.";

                Log.Error(exc, msgErro + "{@g}", grupoDeAutomoveis);

                return Result.Fail(msgErro);
            }
        }









        public Result Excluir(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            Log.Debug("Tentando excluir grupo de automoveis..{@g}", grupoDeAutomoveis);

            try
            {
                bool grupoDeAutomoveisExiste = repositorioGrupoDeAutomoveis.Existe(grupoDeAutomoveis);

                if (grupoDeAutomoveisExiste == false)
                {
                    Log.Warning("Grupo de Automoveis {GpDeAutomoveisId} não encontrada para excluir", grupoDeAutomoveis.Id);

                    return Result.Fail("Grupo de Automoveis não encontrado");
                }

                repositorioGrupoDeAutomoveis.Deletar(grupoDeAutomoveis);

                Log.Debug("Grupo de Automoveis {GpDeAutomoveisId} excluída com sucesso", grupoDeAutomoveis.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                msgErro = "Falha ao tentar excluir parceiro";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {GpDeAutomoveisId}", grupoDeAutomoveis.Id);

                return Result.Fail(erros);
            }
        }




















































        private bool NomeDuplicado(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            GrupoDeAutomoveis grupoDeAutomoveisEncontrado = repositorioGrupoDeAutomoveis.SelecionarPorNome(grupoDeAutomoveis.Nome);

            if (grupoDeAutomoveisEncontrado != null &&
                grupoDeAutomoveisEncontrado.Id != grupoDeAutomoveis.Id &&
                grupoDeAutomoveisEncontrado.Nome == grupoDeAutomoveis.Nome)
            {
                return true;
            }

            return false;
        }

        private List<string> ValidarGrupoDeAutomoveis(GrupoDeAutomoveis grupoDeAutomoveis)
        {
            var resultadoValidacao = validadorGrupoDeAutomoveis.Validate(grupoDeAutomoveis);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(grupoDeAutomoveis))
                erros.Add($"Este nome '{grupoDeAutomoveis.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

    }
}
