using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Details
    {
        
        public int Id { get; set; }

        public string RestaurantName { get; set; }


        public string Address { get; set; }

        public string UrlImage { get; set; }

        public long ContactNumber { get; set; }

        
    }
}
