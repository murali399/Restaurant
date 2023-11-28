using System.ComponentModel.DataAnnotations;

namespace Restaurant.Dto
{
    public class MenuDto
    {
        [Key]
        public int MenuId { get; set; }

        public int Price { get; set; }
        public string MenuItemName { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public string CategoryName { get; set; }

    }
}
