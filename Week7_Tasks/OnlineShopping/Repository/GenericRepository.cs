using Microsoft.EntityFrameworkCore;
using OnlineShopping.DTOs.ProductDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Repository

{
    public class GenericRepository<TEntity> where TEntity : class
    {
        OnShoppingContext _context;
        public GenericRepository(OnShoppingContext context)
        {
            _context = context;
        }
        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            TEntity p = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(p);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
