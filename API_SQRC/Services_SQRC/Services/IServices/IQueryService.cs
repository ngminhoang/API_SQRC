namespace API_6._0_SQRC.Services.IServices
{
    public interface IQueryService<T> where T : class
    {
        T get(int id);
        List<T> getAll();
    }
}
