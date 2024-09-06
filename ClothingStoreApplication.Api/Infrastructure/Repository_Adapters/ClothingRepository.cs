using ClothingStoreApplication.Api.Core.Domain;
using ClothingStoreApplication.Api.Core.Ports.Repositories;
using ClothingStoreApplication.Api.Infrastructure.ClothingDbContext;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ClothingStoreApplication.Api.Infrastructure.Repository_Adapters
{
    public class ClothingRepository<T> : IClothingRepository<T> where T: ClothingItem
    {
        protected readonly ClothingContext _context;
        private readonly DbSet<T> _dbSet;

        public ClothingRepository(ClothingContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
