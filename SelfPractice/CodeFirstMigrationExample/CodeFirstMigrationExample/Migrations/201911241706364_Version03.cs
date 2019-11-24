namespace CodeFirstMigrationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version03 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 20, unicode: false));
            DropColumn("dbo.Employees", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
