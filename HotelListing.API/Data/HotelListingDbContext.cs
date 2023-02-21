using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
       public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // config data
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id= 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Spa",
                    Address = "Negril",
                    CountryId= 1,
                    Rating= 1,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 3,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 5,
                }
                );
        }
    }
}
