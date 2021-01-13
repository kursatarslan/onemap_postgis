using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace onemap.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SpatialDbContext>
    {
        public SpatialDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SpatialDbContext>();
            builder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=postgres;");
            return new SpatialDbContext(builder.Options);
        }
    }
}