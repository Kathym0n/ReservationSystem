using Microsoft.EntityFrameworkCore;

namespace AirlineReservationSystem
{
    internal class AirlineDbContext : DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; }

    }
}
