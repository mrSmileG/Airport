using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.EF
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aircrew> Aircrews { get; set; }

        public DbSet<Departure> Departures { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Pilot> Pilots { get; set; }

        public DbSet<Plane> Planes { get; set; }

        public DbSet<PlaneType> PlaneTypes { get; set; }

        public DbSet<Steward> Stewards { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
