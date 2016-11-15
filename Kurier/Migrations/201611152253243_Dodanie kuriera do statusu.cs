namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodaniekurieradostatusu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KodStatusu = c.Int(nullable: false),
                        Czas = c.DateTime(nullable: false),
                        Kurier_Id = c.Int(),
                        DanePaczki_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DaneUzytkownikas", t => t.Kurier_Id)
                .ForeignKey("dbo.DanePaczkis", t => t.DanePaczki_Id)
                .Index(t => t.Kurier_Id)
                .Index(t => t.DanePaczki_Id);
            
            AddColumn("dbo.DanePaczkis", "Status_Id", c => c.Int());
            CreateIndex("dbo.DanePaczkis", "Status_Id");
            AddForeignKey("dbo.DanePaczkis", "Status_Id", "dbo.Status", "Id");
            DropColumn("dbo.DanePaczkis", "Status_KodStatusu");
            DropColumn("dbo.DanePaczkis", "Status_CzasNadania");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DanePaczkis", "Status_CzasNadania", c => c.DateTime(nullable: false));
            AddColumn("dbo.DanePaczkis", "Status_KodStatusu", c => c.Int(nullable: false));
            DropForeignKey("dbo.DanePaczkis", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Status", "DanePaczki_Id", "dbo.DanePaczkis");
            DropForeignKey("dbo.Status", "Kurier_Id", "dbo.DaneUzytkownikas");
            DropIndex("dbo.Status", new[] { "DanePaczki_Id" });
            DropIndex("dbo.Status", new[] { "Kurier_Id" });
            DropIndex("dbo.DanePaczkis", new[] { "Status_Id" });
            DropColumn("dbo.DanePaczkis", "Status_Id");
            DropTable("dbo.Status");
        }
    }
}
