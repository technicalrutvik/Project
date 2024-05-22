
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApplication1.Models;

namespace WebApplication1.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepositoty<T> where T : class, IEntityBase, new()
    {
        private readonly AppDBContext _dbContext;

        public EntityBaseRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public async Task AddAsync(T entity) { 
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        
        

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _dbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _dbContext.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _dbContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }


        

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _dbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
    }
}
