namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Haslo = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Telefon = c.Int(),
                        Uprawnienia = c.Int(),
                        Adres_Miasto = c.String(),
                        Adres_KodPocztowy = c.String(),
                        Adres_Ulica = c.String(),
                        Adres_NumerMieszkania = c.String(),
                        NumerPracowanika = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Samochod_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DaneSamochodus", t => t.Samochod_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.Samochod_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.DaneSamochodus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumRejestracyjny = c.String(),
                        Marka = c.String(),
                        Model = c.String(),
                        Stan = c.String(),
                        DataKontroli = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DanePaczkis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPaczki = c.String(),
                        AdresAdresata_Miasto = c.String(),
                        AdresAdresata_KodPocztowy = c.String(),
                        AdresAdresata_Ulica = c.String(),
                        AdresAdresata_NumerMieszkania = c.String(),
                        AdresNadawcy_Miasto = c.String(),
                        AdresNadawcy_KodPocztowy = c.String(),
                        AdresNadawcy_Ulica = c.String(),
                        AdresNadawcy_NumerMieszkania = c.String(),
                        PoczatekObslugi = c.DateTime(),
                        KoniecObslugi = c.DateTime(),
                        Adresat_Id = c.String(maxLength: 128),
                        Nadawca_Id = c.String(maxLength: 128),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Adresat_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Nadawca_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Adresat_Id)
                .Index(t => t.Nadawca_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KodStatusu = c.Int(nullable: false),
                        Czas = c.DateTime(nullable: false),
                        Kurier_Id = c.String(maxLength: 128),
                        DanePaczki_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Kurier_Id)
                .ForeignKey("dbo.DanePaczkis", t => t.DanePaczki_Id)
                .Index(t => t.Kurier_Id)
                .Index(t => t.DanePaczki_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.DanePaczkis", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.DanePaczkis", "Nadawca_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Status", "DanePaczki_Id", "dbo.DanePaczkis");
            DropForeignKey("dbo.Status", "Kurier_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.DanePaczkis", "Adresat_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Samochod_Id", "dbo.DaneSamochodus");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Status", new[] { "DanePaczki_Id" });
            DropIndex("dbo.Status", new[] { "Kurier_Id" });
            DropIndex("dbo.DanePaczkis", new[] { "Status_Id" });
            DropIndex("dbo.DanePaczkis", new[] { "Nadawca_Id" });
            DropIndex("dbo.DanePaczkis", new[] { "Adresat_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Samochod_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Status");
            DropTable("dbo.DanePaczkis");
            DropTable("dbo.DaneSamochodus");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
        }
    }
}
