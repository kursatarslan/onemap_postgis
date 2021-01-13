using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onemap.Data;
using NetTopologySuite.Geometries;

namespace onemap
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<SpatialDbContext>().UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;").Options;
            using (var context = new SpatialDbContext(options))
            {
                Point query = new Point(35.7888256, 37.2408434) { SRID = 4326 };
                const double radiusMeters = 100 * 1000;
                var cities = await context
                    .Citys
                    //.Where(x => x.Point.Distance(query) <= radiusMeters)
                    .OrderBy(x => x.Point.Distance(query))
                    .Select(t => new
                    {
                        t.Name,
                        Distance = t.Point.Distance(query) / 1000
                    })
                    .ToListAsync();

                foreach (var city in cities)
                    Console.WriteLine($"{city.Name}, {Math.Round(city.Distance)} KM");
            }

            Console.ReadLine();
        }
    }
}