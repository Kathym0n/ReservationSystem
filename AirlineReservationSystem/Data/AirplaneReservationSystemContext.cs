using AirlineReservationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

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
            DbPath = Path.Join(path, "AirlineReservation.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explizite Konfiguration der Relationships
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasOne(r => r.Customer)
                      .WithMany()
                      .HasForeignKey(r => r.CustomerID)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Flight)
                      .WithMany()
                      .HasForeignKey(r => r.FlightID)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
