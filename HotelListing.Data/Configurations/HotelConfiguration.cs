
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 1,
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

