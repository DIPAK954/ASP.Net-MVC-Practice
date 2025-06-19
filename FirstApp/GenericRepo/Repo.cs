
using FirstApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FirstApp.GenericRepo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dataSet;

        public Repo(DataContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Get(int id)
        {
            return _dataSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataSet.AsEnumerable();
        }
    }
}
