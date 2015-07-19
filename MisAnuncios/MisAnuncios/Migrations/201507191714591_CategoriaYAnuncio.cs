namespace MisAnuncios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriaYAnuncio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        CategoriaId = c.Int(nullable: false),
                        Autor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Autor_Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.Autor_Id);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Anuncios", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Anuncios", "Autor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Anuncios", new[] { "Autor_Id" });
            DropIndex("dbo.Anuncios", new[] { "CategoriaId" });
            DropTable("dbo.Categorias");
            DropTable("dbo.Anuncios");
        }
    }
}
