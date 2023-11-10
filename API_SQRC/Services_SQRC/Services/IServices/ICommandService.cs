namespace API_6._0_SQRC.Services.IServices
{
    public interface ICommandService<T> where T : class
    {
        bool create(T entity);
        bool delete(int id);
        bool update(int id, T entity);
    }
}
