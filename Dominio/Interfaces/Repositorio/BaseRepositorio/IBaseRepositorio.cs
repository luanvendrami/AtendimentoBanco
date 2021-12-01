using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio.BaseRepositorio
{
    public interface IBaseRepositorio<T> : IDisposable where T : class, new()
    {
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Remover(int id);
        int SalvarAlteracao();
    }
}
