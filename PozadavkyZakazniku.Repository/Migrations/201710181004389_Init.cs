namespace PozadavkyZakazniku.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModuleID);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        Description = c.String(),
                        Author_UserID = c.Int(),
                        Status_StatusID = c.Int(),
                    })
                .PrimaryKey(t => t.RequestID)
                .ForeignKey("dbo.Users", t => t.Author_UserID)
                .ForeignKey("dbo.Status", t => t.Status_StatusID)
                .Index(t => t.Author_UserID)
                .Index(t => t.Status_StatusID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        LoginName = c.String(),
                        LoginPassword = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "Status_StatusID", "dbo.Status");
            DropForeignKey("dbo.Requests", "Author_UserID", "dbo.Users");
            DropIndex("dbo.Requests", new[] { "Status_StatusID" });
            DropIndex("dbo.Requests", new[] { "Author_UserID" });
            DropTable("dbo.Status");
            DropTable("dbo.Users");
            DropTable("dbo.Requests");
            DropTable("dbo.Modules");
        }
    }
}
