namespace CFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version03 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "RegNo", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            CreateIndex("dbo.Students", "Email", unique: true);
            CreateIndex("dbo.Students", "RegNo", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "RegNo" });
            DropIndex("dbo.Students", new[] { "Email" });
            AlterColumn("dbo.Students", "RegNo", c => c.String(nullable: false));
        }
    }
}
