namespace MisAnuncios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CiudadesEnum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Ciudad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Ciudad", c => c.String());
        }
    }
}
