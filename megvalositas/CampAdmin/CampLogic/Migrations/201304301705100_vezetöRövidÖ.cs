namespace CampLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vezetöRövidÖ : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Csoports", "IfiVezeto1_VezetőId", "dbo.Vezető");
            DropForeignKey("dbo.Csoports", "IfiVezeto2_VezetőId", "dbo.Vezető");
            DropIndex("dbo.Csoports", new[] { "IfiVezeto1_VezetőId" });
            DropIndex("dbo.Csoports", new[] { "IfiVezeto2_VezetőId" });
            CreateTable(
                "dbo.Vezetö",
                c => new
                    {
                        VezetőId = c.Int(nullable: false, identity: true),
                        Jelszo = c.String(),
                        Nev = c.String(),
                        TipusSzam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VezetőId);
            
            AddForeignKey("dbo.Csoports", "IfiVezeto1_VezetőId", "dbo.Vezetö", "VezetőId");
            AddForeignKey("dbo.Csoports", "IfiVezeto2_VezetőId", "dbo.Vezetö", "VezetőId");
            CreateIndex("dbo.Csoports", "IfiVezeto1_VezetőId");
            CreateIndex("dbo.Csoports", "IfiVezeto2_VezetőId");
            DropTable("dbo.Vezető");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Vezető",
                c => new
                    {
                        VezetőId = c.Int(nullable: false, identity: true),
                        Jelszo = c.String(),
                        Nev = c.String(),
                        TipusSzam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VezetőId);
            
            DropIndex("dbo.Csoports", new[] { "IfiVezeto2_VezetőId" });
            DropIndex("dbo.Csoports", new[] { "IfiVezeto1_VezetőId" });
            DropForeignKey("dbo.Csoports", "IfiVezeto2_VezetőId", "dbo.Vezetö");
            DropForeignKey("dbo.Csoports", "IfiVezeto1_VezetőId", "dbo.Vezetö");
            DropTable("dbo.Vezetö");
            CreateIndex("dbo.Csoports", "IfiVezeto2_VezetőId");
            CreateIndex("dbo.Csoports", "IfiVezeto1_VezetőId");
            AddForeignKey("dbo.Csoports", "IfiVezeto2_VezetőId", "dbo.Vezető", "VezetőId");
            AddForeignKey("dbo.Csoports", "IfiVezeto1_VezetőId", "dbo.Vezető", "VezetőId");
        }
    }
}
