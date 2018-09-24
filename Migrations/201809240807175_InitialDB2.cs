namespace FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Social", "Link", c => c.String(maxLength: 256));
            DropColumn("dbo.Social", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Social", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.Social", "Link");
        }
    }
}
