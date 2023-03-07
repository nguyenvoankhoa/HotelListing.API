
using HotelListing.API.Models;

namespace HotelListing.API.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
        Task<T> GetAsync(int? id);

        Task<List<TResult>> GetAllAsync<TResult>();
        Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
        Task<TResult> GetAsync<TResult>(int? id);
        Task<TResult> AddAsync<TSource, TResult>(TSource source);
        Task UpdateAsync<TSource>(int id, TSource source) where TSource : IBaseDto;
    }

    
}
