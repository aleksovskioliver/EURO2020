namespace EURO2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGoalsToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Goals", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Goals");
        }
    }
}
