using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LuyenTap.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

       
        
        public virtual DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            
        }

        public System.Data.Entity.DbSet<LuyenTap.Models.Person> People { get; set; }
    }
}
