using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelListing.API.Contract;
using HotelListing.API.Data;
using HotelListing.API.Exceptions;
using HotelListing.API.Models.Country;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;
        private readonly IMapper _mapper;

        public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CountryDto> GetDetails(int id)
        {
            var country = await _context.Countries.Include(q => q.Hotels)
                .ProjectTo<CountryDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (country == null)
            {
                throw new NotFoundException(nameof(GetDetails), id);
            }

            return country;
        }
    }
}
