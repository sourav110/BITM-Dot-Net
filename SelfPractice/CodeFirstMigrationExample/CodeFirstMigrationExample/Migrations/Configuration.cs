namespace CodeFirstMigrationExample.Migrations
{
    using CodeFirstMigrationExample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstMigrationExample.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstMigrationExample.Models.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Employees.AddOrUpdate(
            //    new Employee {Name ="James", Address="Dhaka", Department="HR", Email = "james@mail.com", Password ="123456", ConfirmPassword ="123456", Salary = 20000}
            //    );
        }
    }
}
