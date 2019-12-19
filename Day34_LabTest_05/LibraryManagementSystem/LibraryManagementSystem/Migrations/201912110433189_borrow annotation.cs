namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class borrowannotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Borrows", "MemberNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Borrows", "MemberNo", c => c.String());
        }
    }
}
