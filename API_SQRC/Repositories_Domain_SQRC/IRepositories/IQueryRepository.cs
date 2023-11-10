namespace API_6._0_SQRC.Repositories.IRepositories
{
    public interface IQueryRepository<T> where T: class
    {
        T get(int id);
        List<T> getAll();
    }
}
