using Microsoft.EntityFrameworkCore;
using LogDAL.Repositories.Interfaces;
using LogDAL.URIS2018_G1_M1;

namespace LogDAL.Repositories.Implementations
{
    public abstract class BaseRepositoryImpl<TEntity, K> : IRepository<TEntity, K> where TEntity : class
    {
        protected const short ACTIVE = -1;
        protected const short NOT_ACTIVE = 0;
        protected ErrorDbContext context = new ErrorDbContext();
        protected DbSet<TEntity> DbSet;

        public void Add(TEntity entity)
        {
            context.Database.OpenConnection();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public abstract TEntity GetById(K id);
    }
}
