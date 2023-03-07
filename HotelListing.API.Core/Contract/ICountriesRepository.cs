using HotelListing.API.Data;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Contract
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
