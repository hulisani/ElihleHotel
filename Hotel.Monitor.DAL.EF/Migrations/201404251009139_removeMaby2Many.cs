namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeMaby2Many : DbMigration
    {
        public override void Up()
        {
           // DropForeignKey("dbo.ReservedRoom", "ReservationId", "dbo.Reservations");
           // DropForeignKey("dbo.ReservedRoom", "RoomId", "dbo.HotelRooms");
           // DropIndex("dbo.ReservedRoom", new[] { "ReservationId" });
           // DropIndex("dbo.ReservedRoom", new[] { "RoomId" });
           // DropTable("dbo.ReservedRoom");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReservedRoom",
                c => new
                    {
                        ReservationId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReservationId, t.RoomId });
            
            CreateIndex("dbo.ReservedRoom", "RoomId");
            CreateIndex("dbo.ReservedRoom", "ReservationId");
            AddForeignKey("dbo.ReservedRoom", "RoomId", "dbo.HotelRooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReservedRoom", "ReservationId", "dbo.Reservations", "Id", cascadeDelete: true);
        }
    }
}
