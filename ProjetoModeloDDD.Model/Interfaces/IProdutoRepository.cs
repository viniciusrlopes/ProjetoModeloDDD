
using System.Collections;
using System.Collections.Generic;
using ProjetoModeloDDD.Model.Entities;

namespace ProjetoModeloDDD.Model.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
