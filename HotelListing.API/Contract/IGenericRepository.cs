using HotelListing.API.Data;

namespace HotelListing.API.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T item);
        Task DeleteAsync(int id);
        Task UpdateAsync(T item);
        Task<bool> Exists(int id);
        Task<T> GetAsync(int? id);
    }

    
}
