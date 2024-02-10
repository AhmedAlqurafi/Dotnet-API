using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 6,
                    Name = "Royal Villa",
                    Details = "Blah Blag Blah",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 4.5,
                    sqft = 1200,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                 new Villa()
                 {
                     Id = 7,
                     Name = "Royal Villa",
                     Details = "Blah Blag Blah",
                     ImageUrl = "",
                     Occupancy = 5,
                     Rate = 4.5,
                     sqft = 1200,
                     Amenity = "",
                    CreatedDate = DateTime.Now,
                 }, new Villa()
                 {
                     Id = 3,
                     Name = "Royal Villa",
                     Details = "Blah Blag Blah",
                     ImageUrl = "",
                     Occupancy = 5,
                     Rate = 4.5,
                     sqft = 1200,
                     Amenity = "",
                     CreatedDate = DateTime.Now,
                 }, new Villa()
                 {
                     Id = 4,
                     Name = "Royal Villa",
                     Details = "Blah Blag Blah",
                     ImageUrl = "",
                     Occupancy = 5,
                     Rate = 4.5,
                     sqft = 1200,
                     CreatedDate = DateTime.Now,
                     Amenity = ""
                 }, new Villa()
                 {
                     Id = 5,
                     Name = "Royal Villa",
                     Details = "Blah Blag Blah",
                     ImageUrl = "",
                     Occupancy = 5,
                     Rate = 4.5,
                     sqft = 1200,
                     Amenity = "",
                     CreatedDate = DateTime.Now,
                 }
                );
        }
    }
}
