namespace SupriyaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.courseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
