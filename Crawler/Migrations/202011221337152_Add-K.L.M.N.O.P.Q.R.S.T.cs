namespace Crawler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKLMNOPQRST : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KPlayers",
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
                "dbo.LPlayers",
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
                "dbo.MPlayers",
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
                "dbo.NPlayers",
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
                "dbo.OPlayers",
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
                "dbo.PPlayers",
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
                "dbo.QPlayers",
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
                "dbo.RPlayers",
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
                "dbo.SPlayers",
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
                "dbo.TPlayers",
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
            DropTable("dbo.TPlayers");
            DropTable("dbo.SPlayers");
            DropTable("dbo.RPlayers");
            DropTable("dbo.QPlayers");
            DropTable("dbo.PPlayers");
            DropTable("dbo.OPlayers");
            DropTable("dbo.NPlayers");
            DropTable("dbo.MPlayers");
            DropTable("dbo.LPlayers");
            DropTable("dbo.KPlayers");
        }
    }
}
