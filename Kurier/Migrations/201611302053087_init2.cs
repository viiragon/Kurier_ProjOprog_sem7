namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "KurierKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "KurierKey", c => c.Int());
        }
    }
}
