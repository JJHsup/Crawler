namespace Crawler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.XPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.YPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ZPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        G = c.String(),
                        PTS = c.String(),
                        TRB = c.String(),
                        AST = c.String(),
                        FG = c.String(),
                        FG3 = c.String(),
                        FT = c.String(),
                        eFG = c.String(),
                        PER = c.String(),
                        WS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ZPlayers");
            DropTable("dbo.YPlayers");
            DropTable("dbo.XPlayers");
            DropTable("dbo.WPlayers");
            DropTable("dbo.VPlayers");
            DropTable("dbo.UPlayers");
        }
    }
}
