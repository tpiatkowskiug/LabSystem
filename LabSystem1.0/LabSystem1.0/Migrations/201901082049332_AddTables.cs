namespace LabSystem1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Voivodeship = c.String(),
                        Commune = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Street = c.String(),
                        PhonePreferred = c.Boolean(nullable: false),
                        Phone = c.String(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        NameAndSurname = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Region = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        QuantitySample = c.Int(nullable: false),
                        MarkingSample = c.String(),
                        PriceListId = c.Int(),
                        PriceOrder = c.Single(),
                        OrderCreationDate = c.DateTime(nullable: false),
                        EmployeeId = c.Int(),
                        CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.PriceLists", t => t.PriceListId)
                .Index(t => t.PriceListId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.PriceLists",
                c => new
                    {
                        PriceListId = c.Int(nullable: false, identity: true),
                        TypeOfResearch = c.String(),
                        PriceNetto = c.Single(nullable: false),
                        PriceBrutto = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PriceListId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PriceListId", "dbo.PriceLists");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "PriceListId" });
            DropIndex("dbo.Customers", new[] { "EmployeeId" });
            DropTable("dbo.PriceLists");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
