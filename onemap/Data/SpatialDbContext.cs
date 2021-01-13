using System;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace onemap.Data
{
    public class SpatialDbContext : DbContext
    {
        public DbSet<City> Citys { get; set; }

        public SpatialDbContext(DbContextOptions<SpatialDbContext> options)
         : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;", x => x.UseNetTopologySuite());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("postgis");

            modelBuilder
                .ApplyConfiguration(new CityConfiguration());
                modelBuilder.HasDefaultSchema("OneMap");

            GeometryFactory geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            // longitude as the first parameter(x) and the latitude as the second parameter(y)
 
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ADANA" ,Point = geometryFactory.CreatePoint(new Coordinate(37, 35.321333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ADIYAMAN" ,Point = geometryFactory.CreatePoint(new Coordinate(37.764751, 38.278561))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "AFYONKARAHİSAR" ,Point = geometryFactory.CreatePoint(new Coordinate(38.750714, 30.556692))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "AĞRI" ,Point = geometryFactory.CreatePoint(new Coordinate(39.626922, 43.021596))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "AKSARAY" ,Point = geometryFactory.CreatePoint(new Coordinate(38.36869, 34.03698))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "AMASYA" ,Point = geometryFactory.CreatePoint(new Coordinate(40.64991, 35.83532))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ANKARA" ,Point = geometryFactory.CreatePoint(new Coordinate(39.92077, 32.85411))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ANTALYA" ,Point = geometryFactory.CreatePoint(new Coordinate(36.88414, 30.70563))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ARDAHAN" ,Point = geometryFactory.CreatePoint(new Coordinate(41.110481, 42.702171))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ARTVİN" ,Point = geometryFactory.CreatePoint(new Coordinate(41.18277, 41.818292))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "AYDIN" ,Point = geometryFactory.CreatePoint(new Coordinate(37.856041, 27.841631))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BALIKESİR" ,Point = geometryFactory.CreatePoint(new Coordinate(39.648369, 27.88261))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BARTIN" ,Point = geometryFactory.CreatePoint(new Coordinate(41.581051, 32.460979))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BATMAN" ,Point = geometryFactory.CreatePoint(new Coordinate(37.881168, 41.13509))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BAYBURT" ,Point = geometryFactory.CreatePoint(new Coordinate(40.255169, 40.22488))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BİLECİK" ,Point = geometryFactory.CreatePoint(new Coordinate(40.056656, 30.066524))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BİNGÖL" ,Point = geometryFactory.CreatePoint(new Coordinate(39.062635, 40.76961))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BİTLİS" ,Point = geometryFactory.CreatePoint(new Coordinate(38.393799, 42.12318))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BOLU" ,Point = geometryFactory.CreatePoint(new Coordinate(40.575977, 31.578809))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BURDUR" ,Point = geometryFactory.CreatePoint(new Coordinate(37.461267, 30.066524))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "BURSA" ,Point = geometryFactory.CreatePoint(new Coordinate(40.266864, 29.063448))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ÇANAKKALE" ,Point = geometryFactory.CreatePoint(new Coordinate(40.155312, 26.41416))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ÇANKIRI" ,Point = geometryFactory.CreatePoint(new Coordinate(40.601343, 33.613421))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ÇORUM" ,Point = geometryFactory.CreatePoint(new Coordinate(40.550556, 34.955556))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "DENİZLİ" ,Point = geometryFactory.CreatePoint(new Coordinate(37.77652, 29.08639))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "DİYARBAKIR" ,Point = geometryFactory.CreatePoint(new Coordinate(37.91441, 40.230629))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "DÜZCE" ,Point = geometryFactory.CreatePoint(new Coordinate(40.843849, 31.15654))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "EDİRNE" ,Point = geometryFactory.CreatePoint(new Coordinate(41.681808, 26.562269))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ELAZIĞ" ,Point = geometryFactory.CreatePoint(new Coordinate(38.680969, 39.226398))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ERZİNCAN" ,Point = geometryFactory.CreatePoint(new Coordinate(39.75, 39.5))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ERZURUM" ,Point = geometryFactory.CreatePoint(new Coordinate(39.9, 41.27))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ESKİŞEHİR" ,Point = geometryFactory.CreatePoint(new Coordinate(39.776667, 30.520556))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "GAZİANTEP" ,Point = geometryFactory.CreatePoint(new Coordinate(37.06622, 37.38332))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "GİRESUN" ,Point = geometryFactory.CreatePoint(new Coordinate(40.912811, 38.38953))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "GÜMÜŞHANE" ,Point = geometryFactory.CreatePoint(new Coordinate(40.438588, 39.508556))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "HAKKARİ" ,Point = geometryFactory.CreatePoint(new Coordinate(37.583333, 43.733333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "HATAY" ,Point = geometryFactory.CreatePoint(new Coordinate(36.401849, 36.34981))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "IĞDIR" ,Point = geometryFactory.CreatePoint(new Coordinate(39.887984, 44.004836))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ISPARTA" ,Point = geometryFactory.CreatePoint(new Coordinate(37.764771, 30.556561))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "İSTANBUL" ,Point = geometryFactory.CreatePoint(new Coordinate(41.00527, 28.97696))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "İZMİR" ,Point = geometryFactory.CreatePoint(new Coordinate(38.41885, 27.12872))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KAHRAMANMARAŞ" ,Point = geometryFactory.CreatePoint(new Coordinate(37.585831, 36.937149))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KARABÜK" ,Point = geometryFactory.CreatePoint(new Coordinate(41.2061, 32.62035))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KARAMAN" ,Point = geometryFactory.CreatePoint(new Coordinate(37.17593, 33.228748))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KARS" ,Point = geometryFactory.CreatePoint(new Coordinate(40.616667, 43.1))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KASTAMONU" ,Point = geometryFactory.CreatePoint(new Coordinate(41.38871, 33.78273))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KAYSERİ" ,Point = geometryFactory.CreatePoint(new Coordinate(38.73122, 35.478729))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KIRIKKALE" ,Point = geometryFactory.CreatePoint(new Coordinate(39.846821, 33.515251))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KIRKLARELİ" ,Point = geometryFactory.CreatePoint(new Coordinate(41.733333, 27.216667))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KIRŞEHİR" ,Point = geometryFactory.CreatePoint(new Coordinate(39.14249, 34.17091))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KİLİS" ,Point = geometryFactory.CreatePoint(new Coordinate(36.718399, 37.12122))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KOCAELİ" ,Point = geometryFactory.CreatePoint(new Coordinate(40.85327, 29.88152))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KONYA" ,Point = geometryFactory.CreatePoint(new Coordinate(37.866667, 32.483333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "KÜTAHYA" ,Point = geometryFactory.CreatePoint(new Coordinate(39.416667, 29.983333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MALATYA" ,Point = geometryFactory.CreatePoint(new Coordinate(38.35519, 38.30946))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MANİSA" ,Point = geometryFactory.CreatePoint(new Coordinate(38.619099, 27.428921))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MARDİN" ,Point = geometryFactory.CreatePoint(new Coordinate(37.321163, 40.724477))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MERSİN" ,Point = geometryFactory.CreatePoint(new Coordinate(36.8, 34.633333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MUĞLA" ,Point = geometryFactory.CreatePoint(new Coordinate(37.215278, 28.363611))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "MUŞ" ,Point = geometryFactory.CreatePoint(new Coordinate(38.946189, 41.753893))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "NEVŞEHİR" ,Point = geometryFactory.CreatePoint(new Coordinate(38.69394, 34.685651))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "NİĞDE" ,Point = geometryFactory.CreatePoint(new Coordinate(37.966667, 34.683333))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ORDU" ,Point = geometryFactory.CreatePoint(new Coordinate(40.983879, 37.876411))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "OSMANİYE" ,Point = geometryFactory.CreatePoint(new Coordinate(37.213026, 36.176261))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "RİZE" ,Point = geometryFactory.CreatePoint(new Coordinate(41.02005, 40.523449))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "SAKARYA" ,Point = geometryFactory.CreatePoint(new Coordinate(40.693997, 30.435763))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "SAMSUN" ,Point = geometryFactory.CreatePoint(new Coordinate(41.292782, 36.33128))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "SİİRT" ,Point = geometryFactory.CreatePoint(new Coordinate(37.933333, 41.95))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "SİNOP" ,Point = geometryFactory.CreatePoint(new Coordinate(42.02314, 35.153069))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "SİVAS" ,Point = geometryFactory.CreatePoint(new Coordinate(39.747662, 37.017879))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ŞANLIURFA" ,Point = geometryFactory.CreatePoint(new Coordinate(37.159149, 38.796909))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ŞIRNAK" ,Point = geometryFactory.CreatePoint(new Coordinate(37.418748, 42.491834))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "TEKİRDAĞ" ,Point = geometryFactory.CreatePoint(new Coordinate(40.983333, 27.516667))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "TOKAT" ,Point = geometryFactory.CreatePoint(new Coordinate(40.316667, 36.55))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "TRABZON" ,Point = geometryFactory.CreatePoint(new Coordinate(41.00145, 39.7178))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "TUNCELİ" ,Point = geometryFactory.CreatePoint(new Coordinate(39.307355, 39.438778))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "UŞAK" ,Point = geometryFactory.CreatePoint(new Coordinate(38.682301, 29.40819))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "VAN" ,Point = geometryFactory.CreatePoint(new Coordinate(38.48914, 43.40889))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "YALOVA" ,Point = geometryFactory.CreatePoint(new Coordinate(40.65, 29.266667))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "YOZGAT" ,Point = geometryFactory.CreatePoint(new Coordinate(39.818081, 34.81469))});
            modelBuilder.Entity<City>().HasData(new City{ Id = Guid.NewGuid(), Name = "ZONGULDAK" ,Point = geometryFactory.CreatePoint(new Coordinate(41.456409, 31.798731))});

        }
    }
}