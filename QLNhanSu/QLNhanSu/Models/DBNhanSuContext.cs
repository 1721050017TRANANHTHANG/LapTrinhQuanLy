using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLNhanSu.Models
{
    public partial class DBNhanSuContext : DbContext
    {
        public DBNhanSuContext()
            : base("name=DBNhanSuConnectionString")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.ChucVu)
                .HasForeignKey(e => e.IdChucVu);
        }
    }
}
