using BookShelf.Data.Configuratrions;
using BookShelf.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Author>(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration<Book>(new BookConfiguration());
        }
    }
}
