namespace API_6._0_SQRC.Repositories.IRepositories
{
    public interface ICommandRepository<T> where T : class
    {
        bool create(T entity);
        bool update(T entity);
        bool delete(int id);
    }
}
