using System.ComponentModel.DataAnnotations;

namespace EgoWebApp.Models
{
    public class ProductCatagory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Catagory { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }
    }
}
