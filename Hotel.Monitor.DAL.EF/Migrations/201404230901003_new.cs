namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Breakfast");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Breakfast", c => c.Boolean(nullable: false));
        }
    }
}
