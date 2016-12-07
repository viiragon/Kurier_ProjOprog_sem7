namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniezewnetrzengoiddlapaczki : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanePaczkis", "IdPaczki", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DanePaczkis", "IdPaczki");
        }
    }
}
