namespace LabSystem1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePriceOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "PriceOrder", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PriceOrder", c => c.Single());
        }
    }
}
