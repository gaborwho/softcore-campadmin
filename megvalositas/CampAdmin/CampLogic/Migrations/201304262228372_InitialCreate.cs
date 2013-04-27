namespace CampLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Csoports",
                c => new
                    {
                        CoportId = c.Int(nullable: false, identity: true),
                        KorcsoportId = c.Int(nullable: false),
                        Nev = c.String(),
                        IfiVezeto1_VezetőId = c.Int(),
                        IfiVezeto2_VezetőId = c.Int(),
                    })
                .PrimaryKey(t => t.CoportId)
                .ForeignKey("dbo.Korcsoports", t => t.KorcsoportId, cascadeDelete: true)
                .ForeignKey("dbo.Vezető", t => t.IfiVezeto1_VezetőId)
                .ForeignKey("dbo.Vezető", t => t.IfiVezeto2_VezetőId)
                .Index(t => t.KorcsoportId)
                .Index(t => t.IfiVezeto1_VezetőId)
                .Index(t => t.IfiVezeto2_VezetőId);
            
            CreateTable(
                "dbo.Korcsoports",
                c => new
                    {
                        KorcsoportId = c.Int(nullable: false, identity: true),
                        TurnusId = c.Int(nullable: false),
                        KorosztalyAlsoKorlat = c.Int(nullable: false),
                        KorosztalyFelsoKorlat = c.Int(nullable: false),
                        Nev = c.String(),
                        Orszag = c.String(),
                    })
                .PrimaryKey(t => t.KorcsoportId)
                .ForeignKey("dbo.Turnus", t => t.TurnusId, cascadeDelete: true)
                .Index(t => t.TurnusId);
            
            CreateTable(
                "dbo.Turnus",
                c => new
                    {
                        TurnusId = c.Int(nullable: false, identity: true),
                        Aktív = c.Boolean(nullable: false),
                        Befejezes = c.DateTime(nullable: false),
                        Kezdes = c.DateTime(nullable: false),
                        Nev = c.String(),
                        Sorszam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TurnusId);
            
            CreateTable(
                "dbo.Táborozó",
                c => new
                    {
                        TáborozóId = c.Int(nullable: false, identity: true),
                        CsoportId = c.Int(nullable: false),
                        Betegsegek = c.String(),
                        Elerhetosegek = c.String(),
                        Megjegyzes = c.String(),
                        Nev = c.String(),
                        Orszag = c.String(),
                        SzobaId = c.Int(nullable: false),
                        SzuletesiDatum = c.DateTime(nullable: false),
                        Csoport_CoportId = c.Int(),
                    })
                .PrimaryKey(t => t.TáborozóId)
                .ForeignKey("dbo.Csoports", t => t.Csoport_CoportId)
                .ForeignKey("dbo.Szobas", t => t.SzobaId, cascadeDelete: true)
                .Index(t => t.Csoport_CoportId)
                .Index(t => t.SzobaId);
            
            CreateTable(
                "dbo.Szobas",
                c => new
                    {
                        SzobaId = c.Int(nullable: false, identity: true),
                        Ferohely = c.Int(nullable: false),
                        Szobaszam = c.String(),
                        Ház_HázId = c.Int(),
                    })
                .PrimaryKey(t => t.SzobaId)
                .ForeignKey("dbo.Ház", t => t.Ház_HázId)
                .Index(t => t.Ház_HázId);
            
            CreateTable(
                "dbo.Ház",
                c => new
                    {
                        HázId = c.Int(nullable: false, identity: true),
                        MapX = c.Int(nullable: false),
                        MapY = c.Int(nullable: false),
                        Név = c.String(),
                    })
                .PrimaryKey(t => t.HázId);
            
            CreateTable(
                "dbo.Vezető",
                c => new
                    {
                        VezetőId = c.Int(nullable: false, identity: true),
                        Jelszo = c.String(),
                        Nev = c.String(),
                    })
                .PrimaryKey(t => t.VezetőId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Szobas", new[] { "Ház_HázId" });
            DropIndex("dbo.Táborozó", new[] { "SzobaId" });
            DropIndex("dbo.Táborozó", new[] { "Csoport_CoportId" });
            DropIndex("dbo.Korcsoports", new[] { "TurnusId" });
            DropIndex("dbo.Csoports", new[] { "IfiVezeto2_VezetőId" });
            DropIndex("dbo.Csoports", new[] { "IfiVezeto1_VezetőId" });
            DropIndex("dbo.Csoports", new[] { "KorcsoportId" });
            DropForeignKey("dbo.Szobas", "Ház_HázId", "dbo.Ház");
            DropForeignKey("dbo.Táborozó", "SzobaId", "dbo.Szobas");
            DropForeignKey("dbo.Táborozó", "Csoport_CoportId", "dbo.Csoports");
            DropForeignKey("dbo.Korcsoports", "TurnusId", "dbo.Turnus");
            DropForeignKey("dbo.Csoports", "IfiVezeto2_VezetőId", "dbo.Vezető");
            DropForeignKey("dbo.Csoports", "IfiVezeto1_VezetőId", "dbo.Vezető");
            DropForeignKey("dbo.Csoports", "KorcsoportId", "dbo.Korcsoports");
            DropTable("dbo.Vezető");
            DropTable("dbo.Ház");
            DropTable("dbo.Szobas");
            DropTable("dbo.Táborozó");
            DropTable("dbo.Turnus");
            DropTable("dbo.Korcsoports");
            DropTable("dbo.Csoports");
        }
    }
}
