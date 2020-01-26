namespace Envision.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userobjectasproponprojectclass : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Projects", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Projects", "UserID");
            RenameColumn(table: "dbo.Projects", name: "ApplicationUser_Id", newName: "UserID");
            AlterColumn("dbo.Projects", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Projects", "UserID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Projects", new[] { "UserID" });
            AlterColumn("dbo.Projects", "UserID", c => c.String());
            RenameColumn(table: "dbo.Projects", name: "UserID", newName: "ApplicationUser_Id");
            AddColumn("dbo.Projects", "UserID", c => c.String());
            CreateIndex("dbo.Projects", "ApplicationUser_Id");
        }
    }
}
