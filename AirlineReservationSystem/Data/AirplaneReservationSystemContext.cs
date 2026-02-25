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
        //entities
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<FlightSeat> FlightSeats { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationSeat> ReservationSeats { get; set; }
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
            // Airplane -> Seats (1:n)
            modelBuilder.Entity<Seat>()
                        .HasOne(s => s.Airplane)
                        .WithMany(a => a.Seats)
                        .HasForeignKey(s => s.AirplaneID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Airplane -> Flight (1:n)
            modelBuilder.Entity<Flight>()
                        .HasOne(f => f.Airplane)
                        .WithMany(a => a.Flights)
                        .HasForeignKey(f => f.AirplaneID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Flight + Seats -> FlightSeat (1:n)
            modelBuilder.Entity<FlightSeat>()
                        .HasOne(fs => fs.Flight)
                        .WithMany(f => f.FlightSeats)
                        .HasForeignKey(fs => fs.FlightID)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FlightSeat>()
                        .HasOne(fs => fs.Seat)
                        .WithMany(f => f.FlightSeats)
                        .HasForeignKey(fs => fs.SeatID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Customer -> Reservations (1:n)
            modelBuilder.Entity<Reservation>()
                        .HasOne(r => r.Customer)
                        .WithMany(c => c.Reservations)
                        .HasForeignKey(r => r.CustomerID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Flight -> Reservations (1:n)
            modelBuilder.Entity<Reservation>()
                        .HasOne(r => r.Flight)
                        .WithMany(f => f.Reservations)
                        .HasForeignKey(r => r.FlightID)
                        .OnDelete(DeleteBehavior.Restrict);

            // Reservation + FlightSeat -> ReservationSeat (1:n)
            modelBuilder.Entity<ReservationSeat>()
                        .HasOne(rs => rs.Reservation)
                        .WithMany(r => r.ReservationSeats)
                        .HasForeignKey(rs => rs.ReservationID)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReservationSeat>()
                        .HasOne(rs => rs.FlightSeat)
                        .WithMany()
                        .HasForeignKey(rs => rs.FlightSeatID)
                        .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
