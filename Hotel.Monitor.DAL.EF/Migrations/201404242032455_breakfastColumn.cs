namespace Hotel.Monitor.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class breakfastColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Breakfast", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reservations", "NumberOfPersons", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "NumberOfPersons");
            DropColumn("dbo.Reservations", "Breakfast");
        }
    }
}
