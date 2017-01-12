namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DaneSamochodus", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.DaneSamochodus", "Kurier_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.DaneSamochodus", "Kurier_Id");
            AddForeignKey("dbo.DaneSamochodus", "Kurier_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaneSamochodus", "Kurier_Id", "dbo.AspNetUsers");
            DropIndex("dbo.DaneSamochodus", new[] { "Kurier_Id" });
            DropColumn("dbo.DaneSamochodus", "Kurier_Id");
            DropColumn("dbo.DaneSamochodus", "Discriminator");
        }
    }
}
