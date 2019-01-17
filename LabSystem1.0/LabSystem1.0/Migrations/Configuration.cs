namespace LabSystem1._0.Migrations
{
    using LabSystem1._0.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabSystem1._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LabSystem1._0.Models.ApplicationDbContext";
        }

        protected override void Seed(LabSystem1._0.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin"},
                new IdentityRole { Name = "Employee" },
                new IdentityRole { Name = "Customer" },
                new IdentityRole { Name = "Lab" }

                );

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            UserManager.AddToRole("5ea6b8bc-6f52-425f-9d30-498450dfa323", "Admin");
            UserManager.AddToRole("fdb9541b-cdcc-427e-a8d1-f6ada0b15834", "Employee");
            UserManager.AddToRole("7c5414d3-d421-433b-ab66-d8548b7e3909", "Employee");
            UserManager.AddToRole("a880acbf-cc59-41ae-9fe2-8ee3d6b86646", "Employee");
            UserManager.AddToRole("5828b4cd-b4f0-41fb-9a3d-7815d279272e", "Customer");
        }
    }
}
