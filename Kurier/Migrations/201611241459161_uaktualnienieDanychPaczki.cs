namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uaktualnienieDanychPaczki : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanePaczkis", "Adresat_Id", c => c.Int());
            AddColumn("dbo.DanePaczkis", "Nadawca_Id", c => c.Int());
            CreateIndex("dbo.DanePaczkis", "Adresat_Id");
            CreateIndex("dbo.DanePaczkis", "Nadawca_Id");
            AddForeignKey("dbo.DanePaczkis", "Adresat_Id", "dbo.DaneUzytkownikas", "Id");
            AddForeignKey("dbo.DanePaczkis", "Nadawca_Id", "dbo.DaneUzytkownikas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanePaczkis", "Nadawca_Id", "dbo.DaneUzytkownikas");
            DropForeignKey("dbo.DanePaczkis", "Adresat_Id", "dbo.DaneUzytkownikas");
            DropIndex("dbo.DanePaczkis", new[] { "Nadawca_Id" });
            DropIndex("dbo.DanePaczkis", new[] { "Adresat_Id" });
            DropColumn("dbo.DanePaczkis", "Nadawca_Id");
            DropColumn("dbo.DanePaczkis", "Adresat_Id");
        }
    }
}
