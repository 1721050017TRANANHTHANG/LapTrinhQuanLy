using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CKEditor_Demo.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.ArticleID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PersonName)
                .IsUnicode(false);
        }
    }
}
