using System.ComponentModel.DataAnnotations;

namespace EgoWebApp.Models
{
    public class ProductSubcatagory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Subcatagory { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

    }
}
