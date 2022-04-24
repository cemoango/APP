using APP.Business.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AIR.ViewModels;

namespace APP.Data.Context
{
    public class APPDBContext : DbContext
    {
        public APPDBContext(DbContextOptions<APPDBContext> options)
            : base(options)
        {
        }
        public DbSet<Airport> airport { get; set; }
        public DbSet<Airline> airline { get; set; }
        public DbSet<Flight> flight { get; set; }
        public DbSet<Flight_Schedule> flight_Schedule { get; set; }
        public DbSet<AIR.ViewModels.AirlineViewModels> AirlineViewModels { get; set; }
    }
}
