namespace ProtPracticeMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version02 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Departments", new[] { "DepartmentCode" });
            CreateIndex("dbo.Departments", "DepartmentCode", unique: true, name: "Ix_DepartmentCode");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", "Ix_DepartmentCode");
            CreateIndex("dbo.Departments", "DepartmentCode", unique: true);
        }
    }
}
