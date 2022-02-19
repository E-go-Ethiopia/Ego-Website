using EgoWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EgoWebApp.Data
{
    public class InvertoyContext:DbContext
    {
        public InvertoyContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<ProductCatagory> Catagory { get; set; }
        public virtual DbSet<ProductSubcatagory> Subcatagory { get; set; }
    }
}
