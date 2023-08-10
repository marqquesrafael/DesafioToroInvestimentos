using DesafioToroInvestimentos.Domain.Entities;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Infrastructure.Persistence.Configuration;
using System;
using System.Linq;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected ToroInvestimentosDbContext _toroInvestimentosDbContext;

        public BaseRepository(ToroInvestimentosDbContext toroInvestimentosDbContext)
        {
            _toroInvestimentosDbContext = toroInvestimentosDbContext;
        }

        public void Insert(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;

            _toroInvestimentosDbContext.Add(entity);
            _toroInvestimentosDbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            _toroInvestimentosDbContext.Set<TEntity>().Remove(GetById(id));
            _toroInvestimentosDbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;

            _toroInvestimentosDbContext.Set<TEntity>().Update(entity);
            _toroInvestimentosDbContext.SaveChanges();
        }

        public IQueryable<TEntity> Select() => _toroInvestimentosDbContext.Set<TEntity>();

        public TEntity GetById(long id) => _toroInvestimentosDbContext.Set<TEntity>().Find(id);

        public void RemoveSoftly(TEntity entity)
        {
            entity.Active = false;
            Update(entity);
        }
    }
}
