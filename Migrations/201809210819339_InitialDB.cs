namespace FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutSection",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Subject = c.String(maxLength: 256),
                        Text1 = c.String(),
                        Text2 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ColumName = c.String(maxLength: 256),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Header",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PathImageProfier = c.String(),
                        HeaderName = c.String(maxLength: 256),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Navigation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NavName = c.String(maxLength: 256),
                        NavColor = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Portfolio",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PathImage = c.String(maxLength: 256),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Social",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IconSocial = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Social");
            DropTable("dbo.Portfolio");
            DropTable("dbo.Navigation");
            DropTable("dbo.Header");
            DropTable("dbo.Footer");
            DropTable("dbo.AboutSection");
        }
    }
}
