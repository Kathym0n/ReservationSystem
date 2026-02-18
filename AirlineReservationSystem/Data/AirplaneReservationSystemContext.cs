using AirlineReservationSystem.Enums;
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
            // Customer -> Reservations (1:n)
            modelBuilder.Entity<Customer>()
                        .HasMany(c => c.Reservations)
                        .WithOne(r => r.Customer)
                        .HasForeignKey(r => r.CustomerID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Reservations -> Flight (n:1)
            modelBuilder.Entity<Reservation>()
                        .HasOne(r => r.Flight)
                        .WithMany()
                        .HasForeignKey(r => r.FlightID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Flight -> Airplane (n:1)
            modelBuilder.Entity<Flight>()
                        .HasOne(f => f.Airplane)
                        .WithMany()
                        .HasForeignKey(f => f.AirplaneID)
                        .OnDelete(DeleteBehavior.Restrict);


            // TODO: Verbindungen ergänzen?

            // Customer 1───n Reservation n───1 Flight
            //1───n Reservation n───n Seat
            //Flight   1───n Seat
            //Airplane 1───n Seat
            //Airplane 1───n Flight



            base.OnModelCreating(modelBuilder);
        }
    }
}
