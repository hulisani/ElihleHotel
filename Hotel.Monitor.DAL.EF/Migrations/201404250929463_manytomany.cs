namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytomany : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.HotelRooms", newName: "ReservedRooms");
            //DropForeignKey("dbo.HotelRooms", "Reservation_Id", "dbo.Reservations");
            //DropIndex("dbo.HotelRooms", new[] { "Reservation_Id" });
            //CreateIndex("dbo.ReservedRooms", "ReservationId");
            //CreateIndex("dbo.ReservedRooms", "RoomId");
            //AddForeignKey("dbo.ReservedRooms", "ReservationId", "dbo.Reservations", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.ReservedRooms", "RoomId", "dbo.HotelRooms", "Id", cascadeDelete: true);
            //DropColumn("dbo.HotelRooms", "Reservation_Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.HotelRooms", "Reservation_Id", c => c.Int());
            //DropForeignKey("dbo.ReservedRooms", "RoomId", "dbo.HotelRooms");
            //DropForeignKey("dbo.ReservedRooms", "ReservationId", "dbo.Reservations");
            //DropIndex("dbo.ReservedRooms", new[] { "RoomId" });
            //DropIndex("dbo.ReservedRooms", new[] { "ReservationId" });
            //CreateIndex("dbo.HotelRooms", "Reservation_Id");
            //AddForeignKey("dbo.HotelRooms", "Reservation_Id", "dbo.Reservations", "Id");
            //RenameTable(name: "dbo.ReservedRooms", newName: "HotelRooms");
        }
    }
}
