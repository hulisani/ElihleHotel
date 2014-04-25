namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPaymentClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HotelRooms", "ActiveBooking_Id", "dbo.Reservations");
            DropIndex("dbo.HotelRooms", new[] { "ActiveBooking_Id" });
            CreateTable(
                "dbo.ReservationPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .Index(t => t.Reservation_Id);
            
            AddColumn("dbo.Reservations", "CheckedIn", c => c.Boolean(nullable: false));
            AddColumn("dbo.HotelRooms", "Reservation_Id", c => c.Int());
            CreateIndex("dbo.HotelRooms", "Reservation_Id");
            AddForeignKey("dbo.HotelRooms", "Reservation_Id", "dbo.Reservations", "Id");
            DropColumn("dbo.HotelRooms", "ActiveBooking_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HotelRooms", "ActiveBooking_Id", c => c.Int());
            DropForeignKey("dbo.HotelRooms", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ReservationPayments", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.HotelRooms", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationPayments", new[] { "Reservation_Id" });
            DropColumn("dbo.HotelRooms", "Reservation_Id");
            DropColumn("dbo.Reservations", "CheckedIn");
            DropTable("dbo.ReservationPayments");
            CreateIndex("dbo.HotelRooms", "ActiveBooking_Id");
            AddForeignKey("dbo.HotelRooms", "ActiveBooking_Id", "dbo.Reservations", "Id");
        }
    }
}
