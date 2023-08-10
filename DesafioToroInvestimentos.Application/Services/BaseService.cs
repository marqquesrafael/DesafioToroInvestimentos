using DesafioToroInvestimentos.Domain.Entities;
using DesafioToroInvestimentos.Domain.Exceptions;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services;
using System;

namespace DesafioToroInvestimentos.Application.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public bool Create(TEntity entity)
        {
            try
            {
                if (entity.Id != 0)
                    throw new InsertEntityWithIdException();

                _repository.Insert(entity);
                return true;
            }
            catch (InsertEntityWithIdException ex)
            {
                throw ex;
            }
            catch
            {
                return false;
            }
        }

        public void Delete(long id) => _repository.Delete(id);

        public TEntity GetById(long id)
        {
            var entity = _repository.GetById(id);
            return entity;
        }

        public bool RemoveSoftly(long id)
        {
            try
            {
                var entity = GetById(id);

                if (entity is null)
                    throw new EntityNotFoundException(nameof(entity));

                _repository.RemoveSoftly(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
