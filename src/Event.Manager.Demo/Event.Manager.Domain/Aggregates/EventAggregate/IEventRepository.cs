using Event.Manager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Manager.Domain.Aggregates.EventAggregate
{
    public interface IEventRepository : IRepository<EventEntity>
    {
        Task<EventEntity> GetByIdAsync(int id);
        Task<IEnumerable<EventEntity>> GetAllAsync();
        Task<bool> CreateAsync();
        Task<bool> UpdateAsync();
        Task<bool> DeleteAsync();
    }
}
