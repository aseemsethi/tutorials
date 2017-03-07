namespace tutorials.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<tutorials.Models.tutorialsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(tutorials.Models.tutorialsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact
                {
                    Id = 1,
                    firstName = "aseem",
                    lastName = "sethi",
                    email = "aseemsethi@yahoo.com",
                    streetAddress1 = "385",
                    streetAddress2 = "Phase2",
                    City = "Bangalore",
                    State = "KA",
                    Zip = "560066",
                    userId = new Guid("30af6bbc-713b-44b7-a9ee-763ba3bf3606")
                });
        }
    }
}
