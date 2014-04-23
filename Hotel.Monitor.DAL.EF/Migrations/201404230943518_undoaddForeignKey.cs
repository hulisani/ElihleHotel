namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class undoaddForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoomPrices", "RoomType_Id1", "dbo.RoomTypes");
            DropIndex("dbo.RoomPrices", new[] { "RoomType_Id1" });
            DropColumn("dbo.RoomPrices", "RoomType_Id");
            RenameColumn(table: "dbo.RoomPrices", name: "RoomType_Id1", newName: "RoomType_Id");
            AlterColumn("dbo.RoomPrices", "RoomType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.RoomPrices", "RoomType_Id");
            AddForeignKey("dbo.RoomPrices", "RoomType_Id", "dbo.RoomTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomPrices", "RoomType_Id", "dbo.RoomTypes");
            DropIndex("dbo.RoomPrices", new[] { "RoomType_Id" });
            AlterColumn("dbo.RoomPrices", "RoomType_Id", c => c.Int());
            RenameColumn(table: "dbo.RoomPrices", name: "RoomType_Id", newName: "RoomType_Id1");
            AddColumn("dbo.RoomPrices", "RoomType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.RoomPrices", "RoomType_Id1");
            AddForeignKey("dbo.RoomPrices", "RoomType_Id1", "dbo.RoomTypes", "Id");
        }
    }
}
