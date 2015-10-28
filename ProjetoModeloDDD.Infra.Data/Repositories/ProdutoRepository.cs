
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Model.Entities;
using ProjetoModeloDDD.Model.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome.Equals(nome));
        }
    }
}
