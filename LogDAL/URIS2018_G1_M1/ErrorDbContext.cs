using Microsoft.EntityFrameworkCore;
using LogDAL.URIS2018_G1_M1.Data;

namespace LogDAL.URIS2018_G1_M1
{
    public class ErrorDbContext : DbContext
    {
        public ErrorDbContext() { }
        public ErrorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ErrorLog> ErrorLog { get; set; }
        public DbSet<GatewayLog> GatewayLog { get; set; }
        public DbSet<InfoLog> InfoLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ErrorLog>().HasKey(i => i.ErrorId);
            modelBuilder.Entity<GatewayLog>().HasKey(i => i.GatewayLogId);
            modelBuilder.Entity<InfoLog>().HasKey(i => i.InfoLogId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 147.91.175.176; Initial Catalog = URIS2018_G1_M1; User id = URIS2018_G1_M1; Password = URIS2018_Korisnici;");
        }
    }
}
