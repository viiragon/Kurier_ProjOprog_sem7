namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DaneUzytkownikas", "Login", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DaneUzytkownikas", "Login");
        }
    }
}
