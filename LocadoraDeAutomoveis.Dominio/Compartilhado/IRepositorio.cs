﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public interface IRepositorio<TEntidade>
    {
        void Inserir(TEntidade novaEntidade);
        void Atualizar(TEntidade entidade);
        void Deletar(TEntidade entidade);
        bool Existe(TEntidade registro);
        List<TEntidade> RetornarTodos();
        TEntidade Busca(Guid? id);
    }
}
