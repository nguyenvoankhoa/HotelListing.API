﻿using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
