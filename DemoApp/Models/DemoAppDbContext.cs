using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoApp.Models
{
    public partial class DemoAppDbContext : DbContext
    {
        public DemoAppDbContext()
            : base("name=DemoAppDbContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
