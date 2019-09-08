using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LogDAL.URIS2018_G1_M1.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<ErrorDbContext>
    {
        public ErrorDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ErrorDbContext>();
            builder.UseSqlServer("Data source = 147.91.175.176; Initial Catalog = URIS2018_G1_M1; User id = URIS2018_G1_M1; Password = URIS2018_Korisnici;");
            return new ErrorDbContext(builder.Options);
        }
    }
}
