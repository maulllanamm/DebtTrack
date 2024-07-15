using DebtTrack.Domain.Common;

namespace DebtTrack.Application.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Entity> GetBaseRepository<Entity>() where Entity : class, IBaseEntity;
        void BeginTransaction();
        void Commit();
        void Rollback();
        int SaveChanges();
        void Dispose();
    }
}
