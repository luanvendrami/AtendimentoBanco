using Microsoft.EntityFrameworkCore;
using Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces.Repositorio.BaseRepositorio;

namespace Infra.Data.Repositorio.BaseRepositorio
{
    public abstract class BaseRepositorio<T> : IBaseRepositorio<T> where T : class, new()
    {
        protected readonly ContextoSQL _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepositorio(ContextoSQL context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Adicionar(T entity)
        {
            _dbSet.Add(entity);
            SalvarAlteracao();
        }

        public void Atualizar(T entity)
        {
            _dbSet.Update(entity);
            SalvarAlteracao();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Remover(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            SalvarAlteracao();
        }

        public int SalvarAlteracao()
        {
            return _context.SaveChanges();
        }
    }
}
