namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaneUzytkownikas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Adres_Miasto = c.String(),
                        Adres_KodPocztowy = c.String(),
                        Adres_Ulica = c.String(),
                        Adres_NumerMieszkania = c.String(),
                        Telefon = c.Int(nullable: false),
                        Uprawnienia = c.Int(nullable: false),
                        Haslo = c.String(),
                        NumerPracowanika = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DanePaczkis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adres_Miasto = c.String(),
                        Adres_KodPocztowy = c.String(),
                        Adres_Ulica = c.String(),
                        Adres_NumerMieszkania = c.String(),
                        PoczatekObslugi = c.DateTime(nullable: false),
                        KoniecObslugi = c.DateTime(nullable: false),
                        Status_KodStatusu = c.Int(nullable: false),
                        Status_CzasNadania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DaneSamochodus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumRejestracyjny = c.String(),
                        Stan = c.String(),
                        DaneKuriera_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DaneUzytkownikas", t => t.DaneKuriera_Id)
                .Index(t => t.DaneKuriera_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaneSamochodus", "DaneKuriera_Id", "dbo.DaneUzytkownikas");
            DropIndex("dbo.DaneSamochodus", new[] { "DaneKuriera_Id" });
            DropTable("dbo.DaneSamochodus");
            DropTable("dbo.DanePaczkis");
            DropTable("dbo.DaneUzytkownikas");
        }
    }
}
