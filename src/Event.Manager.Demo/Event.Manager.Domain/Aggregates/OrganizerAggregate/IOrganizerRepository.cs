using Event.Manager.Domain.Base;

namespace Event.Manager.Domain.Aggregates.OrganizerAggregate
{
    public  interface IOrganizerRepository: IRepository<OrganizerEntity>
    {
        Task<IEnumerable<OrganizerEntity>> GetAll();
        Task<bool> CreateAsync(OrganizerEntity entity);
        Task<bool> UpdateAsync(OrganizerEntity entity);
        Task<bool> DeleteAsync(OrganizerEntity entity);
        Task<OrganizerEntity> GetAsync(int id);
    }
}
