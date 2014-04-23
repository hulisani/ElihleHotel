namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoomPrices", "RoomType_Id", "dbo.RoomTypes");
            DropIndex("dbo.RoomPrices", new[] { "RoomType_Id" });
            AddColumn("dbo.RoomPrices", "RoomType_Id1", c => c.Int());
            AlterColumn("dbo.RoomPrices", "RoomType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.RoomPrices", "RoomType_Id1");
            AddForeignKey("dbo.RoomPrices", "RoomType_Id1", "dbo.RoomTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomPrices", "RoomType_Id1", "dbo.RoomTypes");
            DropIndex("dbo.RoomPrices", new[] { "RoomType_Id1" });
            AlterColumn("dbo.RoomPrices", "RoomType_Id", c => c.Int());
            DropColumn("dbo.RoomPrices", "RoomType_Id1");
            CreateIndex("dbo.RoomPrices", "RoomType_Id");
            AddForeignKey("dbo.RoomPrices", "RoomType_Id", "dbo.RoomTypes", "Id");
        }
    }
}
