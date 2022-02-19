using System;
using System.ComponentModel.DataAnnotations;

namespace EgoWebApp.Models
{
    public class EgoUser
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Phone_Number { get; set; }

        [Required]
        [StringLength(75)]
        public string Email_Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }


    }
}
