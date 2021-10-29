namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        RG = c.String(),
                        Email = c.String(),
                        Nacimento = c.String(),
                        Telefone = c.String(),
                        NomeMae = c.String(),
                        NaoConstaMae = c.Boolean(nullable: false),
                        NomePai = c.String(),
                        NaoConstaPai = c.Boolean(nullable: false),
                        CEP = c.String(),
                        Profissao = c.String(),
                        Renda = c.String(),
                    })
                .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
