namespace RestFulApi
{
    public interface IGenericRepository<T> where T : class, new()
    {
        T Add(T entity);
        T Delete(T entity);
        T GetById(int Id);
        List<T> GetAll();
        List<T> GetByList(int id);
        T UpdateById(T entity, int id);
    }
}
