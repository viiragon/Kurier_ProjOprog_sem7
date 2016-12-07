namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanienulowalnychdatdopaczki : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DanePaczkis", "PoczatekObslugi", c => c.DateTime());
            AlterColumn("dbo.DanePaczkis", "KoniecObslugi", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DanePaczkis", "KoniecObslugi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DanePaczkis", "PoczatekObslugi", c => c.DateTime(nullable: false));
        }
    }
}
