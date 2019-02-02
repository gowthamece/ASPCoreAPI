using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPIDemo.Entities
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
            Database.Migrate();
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author
            {
             
                AuthorId= Guid.NewGuid(),
                FirstName = "Bob",
                LastName = "Ross",
                Genre = "Drama"

            }, new Author
            {
                AuthorId=Guid.NewGuid(),
                FirstName = "David",
                LastName = "Miller",
                Genre = "Fantasy"
            });
        }

    }
}
