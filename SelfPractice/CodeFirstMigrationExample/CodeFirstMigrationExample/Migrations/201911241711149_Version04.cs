namespace CodeFirstMigrationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salary", c => c.Double(nullable: false));
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 20, unicode: false));
            DropColumn("dbo.Employees", "Salary");
        }
    }
}
