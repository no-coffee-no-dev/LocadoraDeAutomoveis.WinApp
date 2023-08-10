using FluentResults;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
using Microsoft.Data.SqlClient;
using Serilog;

namespace LocadoraDeAutomoveis.Aplicacao.ModuloTaxaServico
{
    public class ServicoTaxaServico
    {
        private IRepositorioTaxaServico repositorioTaxaServico;
        private IValidadorTaxaServico validadorTaxaServico;
        private IContextoPersistencia contextoPersistencia;

        public ServicoTaxaServico(IRepositorioTaxaServico repositorioTaxaServico, IValidadorTaxaServico validadorTaxaServico, IContextoPersistencia contextoPersistencia)
        {
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.validadorTaxaServico = validadorTaxaServico;
            this.contextoPersistencia = contextoPersistencia;
        }

        public Result Inserir(TaxaServico taxaServico)
        {
            Log.Debug("Tentando inserir TaxaServico...{@c}", taxaServico);

            List<string> erros = ValidarTaxaServico(taxaServico);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();
                return Result.Fail(erros); //cenário 2
            }
            try
            {
                repositorioTaxaServico.Inserir(taxaServico);

                contextoPersistencia.GravarDados();

                Log.Debug("TaxaServico {TaxaServicoId} inserido com sucesso", taxaServico.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir TaxaServico.";

                Log.Error(exc, msgErro + "{@c}", taxaServico);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Atualizar(TaxaServico taxaServico)
        {
            Log.Debug("Tentando editar TaxaServico...{@c}", taxaServico);

            List<string> erros = ValidarTaxaServico(taxaServico);

            if (erros.Count() > 0)
            {
                contextoPersistencia.DesfazerAlteracoes();
                return Result.Fail(erros);
            }
            try
            {
                repositorioTaxaServico.Atualizar(taxaServico);

                contextoPersistencia.GravarDados();

                Log.Debug("TaxaServico {TaxaServicoId} editado com sucesso", taxaServico.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar TaxaServico.";

                Log.Error(exc, msgErro + "{@c}", taxaServico);

                return Result.Fail(msgErro);
            }
        }


        public Result Excluir(TaxaServico taxaServico)
        {
            Log.Debug("Tentando excluir TaxaServico...{@c}", taxaServico);

            try
            {
                bool TaxaServicoExiste = repositorioTaxaServico.Existe(taxaServico);

                if (TaxaServicoExiste == false)
                {
                    Log.Warning("TaxaServico {TaxaServicoId} não encontrada para excluir", taxaServico.Id);

                    return Result.Fail("TaxaServico não encontrado");
                }

                repositorioTaxaServico.Deletar(taxaServico);

                contextoPersistencia.GravarDados();

                Log.Debug("TaxaServico {TaxaServicoId} excluída com sucesso", taxaServico.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                List<string> erros = new List<string>();

                string msgErro = "não foi possivel deletar a TaxaServico";

                Log.Error(ex, msgErro + " {TaxaServicoId}", taxaServico.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarTaxaServico(TaxaServico TaxaServico)
        {
            var resultadoValidacao = validadorTaxaServico.Validate(TaxaServico);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            //if (CpfDuplicado(TaxaServico))
            //    erros.Add($"Este nome '{TaxaServico.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
