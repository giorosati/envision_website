namespace Envision.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addressforproject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Address1", c => c.String());
            AddColumn("dbo.Projects", "Address2", c => c.String());
            AddColumn("dbo.Projects", "City", c => c.String());
            AddColumn("dbo.Projects", "State", c => c.String());
            AddColumn("dbo.Projects", "Zip", c => c.String());
            AddColumn("dbo.Projects", "LocationNotes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "LocationNotes");
            DropColumn("dbo.Projects", "Zip");
            DropColumn("dbo.Projects", "State");
            DropColumn("dbo.Projects", "City");
            DropColumn("dbo.Projects", "Address2");
            DropColumn("dbo.Projects", "Address1");
        }
    }
}
