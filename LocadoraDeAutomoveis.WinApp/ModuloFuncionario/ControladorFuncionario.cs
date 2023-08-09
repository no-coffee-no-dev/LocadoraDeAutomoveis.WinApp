﻿using FluentResults;
using LocadoraDeAutomoveis.Aplicacao.ModuloFuncionario;
using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase

    {
        private IRepositorioFuncionario repositorioFuncionario;
        private TabelaFuncionarioControl tabelaFuncionario;
        private ServicoFuncionario servicoFuncionario;

        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario,ServicoFuncionario servicoFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoFuncionario = servicoFuncionario;
        }

        public override void CarregarEntidades()
        {
            List<Funcionario> funcionario = repositorioFuncionario.RetornarTodos();

            tabelaFuncionario.AtualizarRegistros(funcionario);

            stringRodape = string.Format("Visualizando {0} funcionario{1}", funcionario.Count, funcionario.Count == 1 ? "" : "s");

            TelaPrincipal.Instancia.AtualizarRodape(stringRodape);
        }

        public override void Deletar()
        {
            Guid? id = tabelaFuncionario.ObtemIdSelecionado();

            Funcionario funcionarioSelecionado = repositorioFuncionario.Busca(id);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionário primeiro",
                "Exclusão de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja realmente excluir o funcionário {funcionarioSelecionado.nome}?",
               "Exclusão de Funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoFuncionario.Excluir(funcionarioSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Funcionário",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override ConfigurarToolTipBase ObtemConfiguracaoTooltip()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
