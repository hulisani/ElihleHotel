namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Parking = c.Boolean(nullable: false),
                        Breakfast = c.Boolean(nullable: false),
                        BookingEmployee_Id = c.Int(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.BookingEmployee_Id)
                .ForeignKey("dbo.Customers", t => t.Client_Id)
                .Index(t => t.BookingEmployee_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        IdNumber = c.String(),
                        StartDateOfEmployment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        Title = c.String(),
                        Nationality = c.String(),
                        Contact = c.String(),
                        SpecialRequest = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HotelRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        MaxPeople = c.Int(nullable: false),
                        ActiveBooking_Id = c.Int(),
                        RoomType_Id = c.Int(),
                        Hotel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ActiveBooking_Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_Id)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id)
                .Index(t => t.ActiveBooking_Id)
                .Index(t => t.RoomType_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelRoomType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RoomType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_Id)
                .Index(t => t.RoomType_Id);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        PostalCode = c.String(),
                        HotelSlogan = c.String(),
                        HotelDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HotelRooms", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.HotelRooms", "RoomType_Id", "dbo.RoomTypes");
            DropForeignKey("dbo.RoomPrices", "RoomType_Id", "dbo.RoomTypes");
            DropForeignKey("dbo.HotelRooms", "ActiveBooking_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "BookingEmployee_Id", "dbo.Employees");
            DropIndex("dbo.HotelRooms", new[] { "Hotel_Id" });
            DropIndex("dbo.HotelRooms", new[] { "RoomType_Id" });
            DropIndex("dbo.RoomPrices", new[] { "RoomType_Id" });
            DropIndex("dbo.HotelRooms", new[] { "ActiveBooking_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Reservations", new[] { "BookingEmployee_Id" });
            DropTable("dbo.Hotels");
            DropTable("dbo.RoomPrices");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.HotelRooms");
            DropTable("dbo.Customers");
            DropTable("dbo.Employees");
            DropTable("dbo.Reservations");
        }
    }
}
