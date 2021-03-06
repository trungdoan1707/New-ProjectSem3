namespace AirlinesReservationSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=AirlinesDBContext")
        {
        }

        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Booking_Ticket> Booking_Ticket { get; set; }
        public virtual DbSet<DiscountDetail> DiscountDetails { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<QuantitySeatClass> QuantitySeatClasses { get; set; }
        public virtual DbSet<ReservationMod> ReservationMods { get; set; }
        public virtual DbSet<Router> Routers { get; set; }
        public virtual DbSet<SeatClass> SeatClasses { get; set; }
        public virtual DbSet<SeatDetailByFlight> SeatDetailByFlights { get; set; }
        public virtual DbSet<SeatNumber> SeatNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline>()
                .Property(e => e.AirlineName)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.LogoImage)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Slogan)
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.AirportIATACode)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.CountryIATACode)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.CityIATACode)
                .IsUnicode(false);

            modelBuilder.Entity<Plane>()
                .Property(e => e.PlaneName)
                .IsUnicode(false);

            modelBuilder.Entity<Plane>()
                .Property(e => e.CodeIATAPlane)
                .IsUnicode(false);

            modelBuilder.Entity<ReservationMod>()
                .Property(e => e.ReservationModName)
                .IsUnicode(false);

            modelBuilder.Entity<SeatClass>()
                .Property(e => e.SeatClassName)
                .IsUnicode(false);
        }
    }
}
