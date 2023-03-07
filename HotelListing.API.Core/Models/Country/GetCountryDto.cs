using System.ComponentModel.DataAnnotations.Schema;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }



}
