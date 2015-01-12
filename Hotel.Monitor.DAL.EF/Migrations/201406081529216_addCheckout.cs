namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCheckout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "CheckedOut", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "CheckedOut");
        }
    }
}
