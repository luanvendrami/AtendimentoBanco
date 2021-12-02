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
    public abstract class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class, new()
    {
        protected readonly ContextoSQL _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepositorio(ContextoSQL context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Adicionar(TEntity entity)
        {
            _dbSet.Add(entity);
            SalvarAlteracao();
        }

        public void Atualizar(TEntity entity)
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
