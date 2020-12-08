namespace PaySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserBalance", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "BalanceNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BalanceNumber");
            DropColumn("dbo.AspNetUsers", "UserBalance");
        }
    }
}
