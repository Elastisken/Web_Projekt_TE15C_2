namespace Web_Projekt_TE15C_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameDeveloperID", c => c.Int());
            AddColumn("dbo.GameDevelopers", "Established", c => c.DateTime(nullable: false));
            AddColumn("dbo.GameDevelopers", "About", c => c.String());
            AddColumn("dbo.GameDevelopers", "ImageFile", c => c.String());
            CreateIndex("dbo.Games", "GameDeveloperID");
            AddForeignKey("dbo.Games", "GameDeveloperID", "dbo.GameDevelopers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GameDeveloperID", "dbo.GameDevelopers");
            DropIndex("dbo.Games", new[] { "GameDeveloperID" });
            DropColumn("dbo.GameDevelopers", "ImageFile");
            DropColumn("dbo.GameDevelopers", "About");
            DropColumn("dbo.GameDevelopers", "Established");
            DropColumn("dbo.Games", "GameDeveloperID");
        }
    }
}
