using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace onemap.Data
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> entity)
        {
            entity.ToTable("City");
            entity.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()").HasColumnName("id");
            entity.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnName("name");
            entity.Property(x => x.Point).IsRequired().HasColumnType("geography (point)").HasColumnName("point");
        }
    }
}