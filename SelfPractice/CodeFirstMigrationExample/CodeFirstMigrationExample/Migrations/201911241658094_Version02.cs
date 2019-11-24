namespace CodeFirstMigrationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Department", c => c.String(nullable: false));
        }
    }
}
