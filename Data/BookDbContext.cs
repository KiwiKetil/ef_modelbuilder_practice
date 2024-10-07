using Microsoft.EntityFrameworkCore;
using ModelbuilderAPI;
using ModelbuilderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelbuilderAPI;
public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookCover> BookCovers { get; set; }
    public DbSet<BookReview> BookReviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Author

        modelBuilder.Entity<Author>()
            .HasKey(a => a.Id);

        modelBuilder.Entity<Author>()
            .Property(a => a.Id)
            .IsRequired();

        modelBuilder.Entity<Author>()
            .Property(a => a.FirstName)
            .IsRequired();

        modelBuilder.Entity<Author>()
            .Property(a => a.LastName)
            .IsRequired();

        #endregion Author

        #region Book

        modelBuilder.Entity<Book>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Book>()
           .HasMany(b => b.BookReviews)
           .WithOne(br => br.Book)
           .HasForeignKey(br => br.BookId);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.BookCover)
            .WithOne(bc => bc.Book)
            .HasForeignKey<BookCover>(bc => bc.BookId);

        modelBuilder.Entity<Book>()
            .Property(b => b.Id)
            .IsRequired();

        modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .IsRequired();

        modelBuilder.Entity<Book>()
           .Property(b => b.ReleaseYear)
           .IsRequired();       

        #endregion Book

        #region Genre

        modelBuilder.Entity<Genre>()
            .HasKey(g => g.Id);

        modelBuilder.Entity<Genre>()
            .Property(g => g.Id)
            .IsRequired();

        modelBuilder.Entity<Genre>()
            .Property(g => g.Name)
            .IsRequired();

        #endregion Genre

        #region BookReview

        modelBuilder.Entity<BookReview>()
            .HasKey(br => br.Id);
       
        modelBuilder.Entity<BookReview>()
            .Property(br => br.Id)
            .IsRequired();

        modelBuilder.Entity<BookReview>()
            .Property(br => br.BookId)
            .IsRequired();

        modelBuilder.Entity<BookReview>()
            .Property(br => br.Review)
            .IsRequired();

        #endregion BookReview

        #region BookCover

        modelBuilder.Entity<BookCover>()
            .HasKey(bc => bc.Id);

        modelBuilder.Entity<BookCover>()
          .Property(bc => bc.Id)
          .IsRequired();

        modelBuilder.Entity<BookCover>()
          .Property(bc => bc.BookId)
          .IsRequired();

        modelBuilder.Entity<BookCover>()
         .Property(bc => bc.HttpAddress)
         .IsRequired();

        #endregion BookCover
    }
}
