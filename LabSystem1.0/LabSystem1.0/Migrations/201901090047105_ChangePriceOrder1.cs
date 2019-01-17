namespace LabSystem1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePriceOrder1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "PriceOrder", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PriceOrder", c => c.Single(nullable: false));
        }
    }
}
