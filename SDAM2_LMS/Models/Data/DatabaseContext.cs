using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SDAM2_LMS.Models.Data
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Models/Data/LibraryManagement.db");
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<PersonalID_Info> PersonalIDs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountType>()
                .HasKey(at => at.AccountTypeID);

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.AccountID);
                entity.HasOne(a => a.AccountType)
                      .WithMany(at => at.Accounts)
                      .HasForeignKey(a => a.AccountTypeID);
                entity.HasOne(a => a.PersonalID_Info)
                      .WithOne(pi => pi.Account)
                      .HasForeignKey<Account>(a => a.PersonalID);
            });

            modelBuilder.Entity<Book>()
                .HasKey(b => b.BookID);

            modelBuilder.Entity<Borrowing>(entity =>
            {
                entity.HasKey(b => b.BorrowID);
                entity.HasOne(b => b.Account)
                      .WithMany(a => a.Borrowings)
                      .HasForeignKey(b => b.AccountID);
                entity.HasOne(b => b.Book)
                      .WithMany()
                      .HasForeignKey(b => b.BookID);
            });

            modelBuilder.Entity<PersonalID_Info>()
                .HasKey(pi => pi.PersonalID);
        }
    }
}
