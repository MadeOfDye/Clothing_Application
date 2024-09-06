using ClothingStoreApplication.Api.Core.Domain;
using ClothingStoreApplication.Api.Core.Ports.Repositories;
using ClothingStoreApplication.Api.Infrastructure.ClothingDbContext;
using Microsoft.EntityFrameworkCore;

namespace ClothingStoreApplication.Api.Infrastructure.Repository_Adapters
{
    public class AccessoryRepository: ClothingRepository<Accessory>, IAccessoryRepository
    {
        public AccessoryRepository(ClothingContext context): base(context) { }

        public async Task AddAsync(Accessory item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Accessory>> GetAccessoriesAsync()
        {
            return await _context.Accessories
                                 //.Where(a => a.Type == type)
                                 .ToListAsync();
        }

        public Task<IEnumerable<Accessory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Accessory?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Accessory item)
        {
            throw new NotImplementedException();
        }
    }
}
