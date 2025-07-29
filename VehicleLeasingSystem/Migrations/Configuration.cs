namespace VehicleLeasingSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VehicleLeasingSystem.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VehicleLeasingSystem.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            // Add Suppliers
            var supplier1 = new Supplier { Name = "Toyota SA" };
            var supplier2 = new Supplier { Name = "Ford Group" };

            // Add Branches
            var branch1 = new Branch { Name = "Johannesburg" };
            var branch2 = new Branch { Name = "Cape Town" };

            // Add Clients
            var client1 = new Client { CompanyName = "ABC Construction" };
            var client2 = new Client { CompanyName = "XZY Mining Ltd" };

            // Add Drivers
            var driver1 = new Driver { FullName = "John Mokoena" };
            var driver2 = new Driver { FullName = "Thabo Ndlovu" };

            context.Suppliers.AddOrUpdate(s => s.Name, supplier1, supplier2);
            context.Branches.AddOrUpdate(b => b.Name, branch1, branch2);
            context.Clients.AddOrUpdate(c => c.CompanyName, client1, client2);
            context.Drivers.AddOrUpdate(d => d.FullName, driver1, driver2);

            context.SaveChanges();

            // Add Vehicles
            context.Vehicles.AddOrUpdate(v => v.Model,
                new Vehicle
                {
                    Manufacturer = "Toyota",
                    Model = "Hilux",
                    SupplierId = supplier1.SupplierId,
                    BranchId = branch1.BranchId,
                    ClientId = client1.ClientId,
                    DriverId = driver1.DriverId
                },
                new Vehicle
                {
                    Manufacturer = "Ford",
                    Model = "Ranger",
                    SupplierId = supplier2.SupplierId,
                    BranchId = branch2.BranchId,
                    ClientId = client2.ClientId,
                    DriverId = driver2.DriverId
                });

            context.SaveChanges();
        }

    }
}
