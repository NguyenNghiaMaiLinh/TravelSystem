using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectDemo12.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo12.Repository
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:ConnectionStr"]);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TourHotel>()
                .HasKey(sc => new { sc.HotelID, sc.TourID });
            modelBuilder.Entity<TourHotel>()
               .HasOne(bc => bc.tbl_Hotel)
               .WithMany(b => b.tbl_TourHotel)
               .HasForeignKey(bc => bc.HotelID);
            modelBuilder.Entity<TourHotel>()
                .HasOne(bc => bc.tbl_Tour)
                .WithMany(c => c.tbl_TourHotel)
                .HasForeignKey(bc => bc.TourID);

            modelBuilder.Entity<ConvenientHotel>()
                .HasKey(sc => new { sc.ConvenientID, sc.HotelID });
            modelBuilder.Entity<ConvenientHotel>()
                .HasOne(bc => bc.tbl_Hotel)
                .WithMany(b => b.tbl_ConvenientHotel)
                .HasForeignKey(bc => bc.HotelID);
            modelBuilder.Entity<ConvenientHotel>()
                .HasOne(bc => bc.tbl_Convenient)
                .WithMany(c => c.tbl_ConvenientHotel)
                .HasForeignKey(bc => bc.ConvenientID);

        }

        public DbSet<Admin> tbl_Admin { get; set; }

        public DbSet<TourGuide> tbl_TourGuide { get; set; }

        public DbSet<Countries> tbl_Country { get; set; }
        
        public DbSet<User> tbl_User { get; set; }

        public DbSet<TravelType> tbl_Travel_Type { get; set; }

        public DbSet<Hotel> tbl_Hotel { get; set; }

        public DbSet<Image> tbl_Image { get; set; }

        public DbSet<Tour> tbl_Tour { get; set; }

        public DbSet<Booking> tbl_Booking { get; set; }

        public DbSet<City> tbl_City { get; set; }

        public DbSet<Passenger> tbl_Passenger { get; set; }

        public DbSet<TourDetail> tbl_TourDetail { get; set; }

        public DbSet<Region> tbl_Region { get; set; }

        public DbSet<Flight> tbl_Flight { get; set; }

        public DbSet<TourHotel> tbl_TourHotel { get; set; }

        public DbSet<Metadata> tbl_Metadata { get; set; }

        public DbSet<ConvenientHotel> tbl_ConvenientHotel { get; set; }

        public DbSet<Convenients> tbl_Convenient { get; set; }

        public DbSet<Office> tbl_Office { get; set; }
    }
}
