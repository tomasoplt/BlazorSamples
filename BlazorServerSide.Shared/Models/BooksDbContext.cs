using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSide.Shared.Models
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=StudentsDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

    }
}
