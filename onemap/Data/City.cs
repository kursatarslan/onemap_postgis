using System;
using NetTopologySuite.Geometries;

namespace onemap.Data
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Point Point { get; set; }
    }
}