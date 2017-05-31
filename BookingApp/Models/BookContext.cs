using System.Data.Entity;

namespace BookingApp.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}