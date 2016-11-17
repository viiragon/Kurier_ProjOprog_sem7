namespace Kurier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DaneSamochodus", name: "DaneKuriera_Id", newName: "Kurier_Id");
            RenameIndex(table: "dbo.DaneSamochodus", name: "IX_DaneKuriera_Id", newName: "IX_Kurier_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.DaneSamochodus", name: "IX_Kurier_Id", newName: "IX_DaneKuriera_Id");
            RenameColumn(table: "dbo.DaneSamochodus", name: "Kurier_Id", newName: "DaneKuriera_Id");
        }
    }
}
