namespace CampLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vezeto1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vezető", "TipusSzam", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vezető", "TipusSzam");
        }
    }
}
