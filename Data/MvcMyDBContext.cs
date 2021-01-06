using System;
using Microsoft.EntityFrameworkCore;
using Book_And_Movie_Tracker.Models;
namespace Book_And_Movie_Tracker.Data
{
    public class MvcMyDBContext : DbContext
    {
        public MvcMyDBContext(DbContextOptions<MvcMyDBContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Book> Book{ get; set; }
    }
}
