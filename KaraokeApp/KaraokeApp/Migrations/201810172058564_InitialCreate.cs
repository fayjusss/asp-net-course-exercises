namespace KaraokeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SongID = c.Int(nullable: false),
                        SingerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Singers", t => t.SingerID, cascadeDelete: true)
                .ForeignKey("dbo.Songs", t => t.SongID, cascadeDelete: true)
                .Index(t => t.SongID)
                .Index(t => t.SingerID);
            
            CreateTable(
                "dbo.Singers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Genre = c.String(nullable: false, maxLength: 50),
                        Artist = c.String(nullable: false, maxLength: 100),
                        Album = c.String(nullable: false, maxLength: 100),
                        Key = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Playlists", "SongID", "dbo.Songs");
            DropForeignKey("dbo.Playlists", "SingerID", "dbo.Singers");
            DropIndex("dbo.Playlists", new[] { "SingerID" });
            DropIndex("dbo.Playlists", new[] { "SongID" });
            DropTable("dbo.Songs");
            DropTable("dbo.Singers");
            DropTable("dbo.Playlists");
        }
    }
}
