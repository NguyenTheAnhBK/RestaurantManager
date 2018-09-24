namespace FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Navigation", "NavBackgroundColor", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Navigation", "NavBackgroundColor");
        }
    }
}
