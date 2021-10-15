namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clientes");
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Cep = c.String(nullable: false, maxLength: 128),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Cep);
            
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Clientes", "CEP", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Clientes", "CPF");
            CreateIndex("dbo.Clientes", "CEP");
            AddForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes", "Cep");
            DropColumn("dbo.Clientes", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "CEP" });
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Clientes", "CEP", c => c.String());
            AlterColumn("dbo.Clientes", "CPF", c => c.String());
            DropTable("dbo.Enderecoes");
            AddPrimaryKey("dbo.Clientes", "ID");
        }
    }
}
