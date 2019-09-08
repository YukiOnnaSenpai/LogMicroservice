namespace LogDAL.Repositories.Interfaces
{
    public interface IRepository<TEntity, K> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(K id);
    }
}
