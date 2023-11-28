using System.ComponentModel.DataAnnotations;

namespace Restaurant.Dto
{
    public class AddMenudto
    {
        [Required]

        public int Price { get; set; }
        [Required]

        public string MenuItemName { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string PhotoUrl { get; set; }
        [Required]

        public string CategoryName { get; set; }

    }
}
