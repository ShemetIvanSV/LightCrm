namespace LightCrmData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreEx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Timetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayOfWeek = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        DayOff = c.Boolean(nullable: false),
                        UserId = c.Boolean(nullable: false),
                        DepartmentId = c.Boolean(nullable: false),
                        Department_Id = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Users", "Surname", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Patronymic", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "RoleId");
            CreateIndex("dbo.Users", "DepartmentId");
            AddForeignKey("dbo.Users", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Timetables", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Timetables", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Timetables", new[] { "User_Id" });
            DropIndex("dbo.Timetables", new[] { "Department_Id" });
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            DropColumn("dbo.Users", "DepartmentId");
            DropColumn("dbo.Users", "RoleId");
            DropColumn("dbo.Users", "Username");
            DropColumn("dbo.Users", "Patronymic");
            DropColumn("dbo.Users", "Surname");
            DropTable("dbo.Timetables");
            DropTable("dbo.Roles");
            DropTable("dbo.Departments");
        }
    }
}
