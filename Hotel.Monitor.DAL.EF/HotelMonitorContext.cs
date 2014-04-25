using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Hotel.Monitor.Entities;

namespace Hotel.Monitor.DAL.EF
{
    public class HotelMonitorContext : DbContext 
    {
        public DbSet<HotelRoom> HotelsRooms { get; set; }
        public DbSet<Hotel.Monitor.Entities.Hotel> Hotel {get;set;}
        public DbSet<Reservation> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RoomPrice> RoomPrices { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<ReservationPayment> ReservationPayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().
              HasMany(r => r.Rooms).
              WithMany(room => room.Reservations).
              Map(
               m =>
               {
                   m.MapLeftKey("ReservationId");
                   m.MapRightKey("RoomId");
                   m.ToTable("ReservedRoom");
               });
        }
    }
}
