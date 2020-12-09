namespace SupriyaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "course_courseId", c => c.Int());
            CreateIndex("dbo.Students", "course_courseId");
            AddForeignKey("dbo.Students", "course_courseId", "dbo.Courses", "courseId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "course_courseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "course_courseId" });
            DropColumn("dbo.Students", "course_courseId");
        }
    }
}
