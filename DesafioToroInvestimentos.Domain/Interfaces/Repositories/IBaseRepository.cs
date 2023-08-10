using DesafioToroInvestimentos.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);

        void Delete(long id);

        void RemoveSoftly(TEntity entity);

        void Update(TEntity entity);

        IQueryable<TEntity> Select();

        TEntity GetById(long id);
    }
}
