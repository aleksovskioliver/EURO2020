namespace EURO2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedplayerphoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "ImgURL", c => c.String());
            AddColumn("dbo.Teams", "Country", c => c.String(nullable: false));
            DropColumn("dbo.Teams", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Teams", "Country");
            DropColumn("dbo.Players", "ImgURL");
        }
    }
}
