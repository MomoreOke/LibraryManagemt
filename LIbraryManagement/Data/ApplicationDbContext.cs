using LIbraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LIbraryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
