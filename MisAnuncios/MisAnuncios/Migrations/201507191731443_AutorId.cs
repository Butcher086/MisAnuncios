namespace MisAnuncios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutorId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Anuncios", name: "Autor_Id", newName: "AutorId");
            RenameIndex(table: "dbo.Anuncios", name: "IX_Autor_Id", newName: "IX_AutorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Anuncios", name: "IX_AutorId", newName: "IX_Autor_Id");
            RenameColumn(table: "dbo.Anuncios", name: "AutorId", newName: "Autor_Id");
        }
    }
}
