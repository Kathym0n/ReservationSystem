using AirlineReservationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AirlineReservationSystem.Data
{
    public class AirplaneReservationSystemContext : DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public string DbPath { get; }

        public AirplaneReservationSystemContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join($"Data Source={DbPath}");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
