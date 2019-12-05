namespace CFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            DropColumn("dbo.Students", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ConfirmPassword", c => c.String(nullable: false));
            DropColumn("dbo.Students", "Email");
        }
    }
}
