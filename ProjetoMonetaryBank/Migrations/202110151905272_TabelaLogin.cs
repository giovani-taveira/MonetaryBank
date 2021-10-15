namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaLogin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "CEP" });
            DropPrimaryKey("dbo.Clientes");
            DropPrimaryKey("dbo.Enderecoes");
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Senha = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CPF);
            
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clientes", "RG", c => c.String(maxLength: 12));
            AlterColumn("dbo.Clientes", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clientes", "Nacimento", c => c.String(maxLength: 10));
            AlterColumn("dbo.Clientes", "Telefone", c => c.String(maxLength: 14));
            AlterColumn("dbo.Clientes", "NomeMae", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clientes", "NomePai", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clientes", "CEP", c => c.String(maxLength: 9));
            AlterColumn("dbo.Clientes", "Profissao", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clientes", "Renda", c => c.String(maxLength: 15));
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.Enderecoes", "Logradouro", c => c.String(maxLength: 100));
            AlterColumn("dbo.Enderecoes", "Numero", c => c.String(maxLength: 10));
            AlterColumn("dbo.Enderecoes", "Complemento", c => c.String(maxLength: 100));
            AlterColumn("dbo.Enderecoes", "Bairro", c => c.String(maxLength: 50));
            AlterColumn("dbo.Enderecoes", "Cidade", c => c.String(maxLength: 50));
            AlterColumn("dbo.Enderecoes", "Estado", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Clientes", "CPF");
            AddPrimaryKey("dbo.Enderecoes", "Cep");
            CreateIndex("dbo.Clientes", "CEP");
            AddForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes", "Cep");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "CEP" });
            DropPrimaryKey("dbo.Enderecoes");
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Enderecoes", "Estado", c => c.String());
            AlterColumn("dbo.Enderecoes", "Cidade", c => c.String());
            AlterColumn("dbo.Enderecoes", "Bairro", c => c.String());
            AlterColumn("dbo.Enderecoes", "Complemento", c => c.String());
            AlterColumn("dbo.Enderecoes", "Numero", c => c.String());
            AlterColumn("dbo.Enderecoes", "Logradouro", c => c.String());
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Clientes", "Renda", c => c.String());
            AlterColumn("dbo.Clientes", "Profissao", c => c.String());
            AlterColumn("dbo.Clientes", "CEP", c => c.String(maxLength: 128));
            AlterColumn("dbo.Clientes", "NomePai", c => c.String());
            AlterColumn("dbo.Clientes", "NomeMae", c => c.String());
            AlterColumn("dbo.Clientes", "Telefone", c => c.String());
            AlterColumn("dbo.Clientes", "Nacimento", c => c.String());
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "RG", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.Logins");
            AddPrimaryKey("dbo.Enderecoes", "Cep");
            AddPrimaryKey("dbo.Clientes", "CPF");
            CreateIndex("dbo.Clientes", "CEP");
            AddForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes", "Cep");
        }
    }
}
