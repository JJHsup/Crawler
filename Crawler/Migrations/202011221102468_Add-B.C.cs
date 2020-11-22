namespace Crawler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BPlayers",
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
                "dbo.CPlayers",
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
            DropTable("dbo.CPlayers");
            DropTable("dbo.BPlayers");
        }
    }
}
