namespace FirstApp.GenericRepo
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
