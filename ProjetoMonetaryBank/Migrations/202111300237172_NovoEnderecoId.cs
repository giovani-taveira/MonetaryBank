namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoEnderecoId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "CEP" });
            DropPrimaryKey("dbo.Enderecoes");
            AddColumn("dbo.Enderecoes", "EnderecoId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(maxLength: 9));
            AddPrimaryKey("dbo.Enderecoes", "EnderecoId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Enderecoes");
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(nullable: false, maxLength: 9));
            DropColumn("dbo.Enderecoes", "EnderecoId");
            AddPrimaryKey("dbo.Enderecoes", "Cep");
            CreateIndex("dbo.Clientes", "CEP");
            AddForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes", "Cep");
        }
    }
}
