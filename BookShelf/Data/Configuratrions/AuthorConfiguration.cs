using BookShelf.Data.Models;
//using BookShelf.Data.Datasets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookShelf.Data.Configuratrions
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.HasData([
                new Author
                {
                    Id = 1,
                    Name = "George Orwell",
                    Country = "United Kingdom"
                },
                new Author
                {
                    Id = 2,
                    Name = "Jane Austen",
                    Country = "United Kingdom"
                },
                new Author
                {
                    Id = 3,
                    Name = "Mark Twain",
                    Country = "United States"
                },
                new Author
                {
                    Id = 4,
                    Name = "Fyodor Dostoevsky",
                    Country = "Russia"
                },
                new Author
                {
                    Id = 5,
                    Name = "Ernest Hemingway",
                    Country = "United States"
                }
            ]);
        }
    }
}
