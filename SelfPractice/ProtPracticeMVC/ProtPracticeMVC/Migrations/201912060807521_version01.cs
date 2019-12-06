namespace ProtPracticeMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentCode = c.String(nullable: false, maxLength: 7, unicode: false),
                        DepartmentName = c.String(nullable: false, maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .Index(t => t.DepartmentCode, unique: true)
                .Index(t => t.DepartmentName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            DropIndex("dbo.Departments", new[] { "DepartmentCode" });
            DropTable("dbo.Departments");
        }
    }
}
