

namespace Domain.DGA.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public abstract void Save(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(TEntity entity);
        public abstract List<TEntity> GetEntities();
        public abstract TEntity GetEntity(int id);
    }
}
