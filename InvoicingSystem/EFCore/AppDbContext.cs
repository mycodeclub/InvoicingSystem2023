using InvoicingSystem.DTO;
using InvoicingSystem.Models.DbModels.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvoicingSystem.EFCore
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //            modelBuilder.SeedRoles();

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });
            modelBuilder.Entity<AppUser>().ToTable("ApplicationUser");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //       optionsBuilder.UseSqlServer(AppSettings.Instance.ConnectionString);
            }
        }


        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }
    }
}
