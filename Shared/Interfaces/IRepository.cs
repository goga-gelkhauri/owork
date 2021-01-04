using System.Threading.Tasks;
using Shared;

namespace Shared.Interfaces
{
    public interface IRepository<T>  where T : BaseEntity, IAggregateRoot
    {
        Task<T> AddAsync(T entity);
    }
}