

using Domain.DGA.Core;
using Infraestructure.DGA.Context;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.DGA.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly Project1DbContext dbContext;
        public DbSet<TEntity> entities;


        public BaseRepository(Project1DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<TEntity>();
        }


        public virtual void Delete(TEntity entity)
        {
            this.entities.Remove(entity);
        }


        public virtual List<TEntity> GetEntities()
        {
            return this.entities.ToList();
        }


        public virtual TEntity GetEntity(int id)
        {
           return this.entities.Find(id);
        }

        public virtual void Save(TEntity entity)
        {
            this.entities.Add(entity);
        }


        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);
        }
    }
}
