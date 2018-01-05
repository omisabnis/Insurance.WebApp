namespace Insurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "AccountNumber", c => c.String());
            AddColumn("dbo.Orders", "ServiceType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ServiceType");
            DropColumn("dbo.Orders", "AccountNumber");
        }
    }
}
