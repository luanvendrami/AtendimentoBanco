using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio.BaseRepositorio
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class, new()
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(int id);
        int SalvarAlteracao();
    }
}
