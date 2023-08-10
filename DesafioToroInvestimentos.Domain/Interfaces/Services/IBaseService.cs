using DesafioToroInvestimentos.Domain.Entities;

namespace DesafioToroInvestimentos.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        bool Create(TEntity entity);

        void Delete(long id);

        bool Update(TEntity entity);

        TEntity GetById(long id);

        bool RemoveSoftly(long id);
    }
}
