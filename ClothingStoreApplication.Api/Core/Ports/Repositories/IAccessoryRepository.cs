
//Currently not used.
using ClothingStoreApplication.Api.Core.Domain;

namespace ClothingStoreApplication.Api.Core.Ports.Repositories
{
    public interface IAccessoryRepository : IClothingRepository<Accessory>
    {
        Task<IEnumerable<Accessory>> GetAccessoriesAsync();
    }
}
