namespace ProtPracticeMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version06 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        SemesterId = c.Int(nullable: false, identity: true),
                        SemesterNo = c.String(),
                    })
                .PrimaryKey(t => t.SemesterId);
            
            AddColumn("dbo.Courses", "SemesterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "SemesterId");
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "SemesterId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropColumn("dbo.Courses", "SemesterId");
            DropTable("dbo.Semesters");
        }
    }
}
