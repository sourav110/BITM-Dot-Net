namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _return : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Returns", "BorrowId", "dbo.Borrows");
            DropIndex("dbo.Returns", new[] { "BorrowId" });
            AddColumn("dbo.Borrows", "IsReturn", c => c.Boolean(nullable: false));
            DropTable("dbo.Returns");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Returns",
                c => new
                    {
                        ReturnId = c.Int(nullable: false, identity: true),
                        MemberNo = c.String(nullable: false),
                        BorrowId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReturnId);
            
            DropColumn("dbo.Borrows", "IsReturn");
            CreateIndex("dbo.Returns", "BorrowId");
            AddForeignKey("dbo.Returns", "BorrowId", "dbo.Borrows", "BorrowId", cascadeDelete: true);
        }
    }
}
