using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-72FTU3Q\\SQLEXPRESS01;Database=HotelDb;Trusted_Connection=true");
        }
        
        public DbSet<Hotel> Hotels { get; set; }
    }
}