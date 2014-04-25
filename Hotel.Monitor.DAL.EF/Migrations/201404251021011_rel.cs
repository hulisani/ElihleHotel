namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservedRoom",
                c => new
                    {
                        ReservationId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReservationId, t.RoomId })
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.HotelRooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservedRoom", "RoomId", "dbo.HotelRooms");
            DropForeignKey("dbo.ReservedRoom", "ReservationId", "dbo.Reservations");
            DropIndex("dbo.ReservedRoom", new[] { "RoomId" });
            DropIndex("dbo.ReservedRoom", new[] { "ReservationId" });
            DropTable("dbo.ReservedRoom");
        }
    }
}
