using ClothingStoreApplication.Api.Core.Domain;
using System;
using System.Collections;

namespace ClothingStoreApplication.Api.Core.Ports.Repositories
{
    public interface IClothingRepository<T> where T: ClothingItem
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(Guid id);
    }
}
